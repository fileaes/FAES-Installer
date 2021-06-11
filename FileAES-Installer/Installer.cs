using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;
using System.Windows.Forms;

namespace FileAES_Installer
{
    public partial class Installer : Form
    {
        private byte _currentView;
        private const byte _maxView = 4;
        private bool _termsAccepted;
        private bool _canInstall;
        private bool _skipCloseCheck;
        private bool _proceedToErrorView;

        public Installer()
        {
            InitializeComponent();
            licencePanel.SetOnLicenceUpdate(TermsChanged);
            optionsPanel.SetCanInstallContinue(InstallOptionsChanged);
            UpdateView();

            InternetCheck();
        }

        private void InternetCheck()
        {
            if (!DoInternetCheck())
            {
                if (MessageBox.Show("Could not connect to the update server!\r\n\r\nPlease ensure you have an internet connection.", "FileAES: Installer | Connection Error", MessageBoxButtons.RetryCancel) == DialogResult.Retry)
                    InternetCheck();
                else
                {
                    _skipCloseCheck = true;
                    Close();
                }
            }
        }

        private void NextView()
        {
            if (_currentView >= _maxView) return;
            _currentView++;
            UpdateView();
        }

        private void PreviousView()
        {
            if (_currentView > 0)
            {
                _currentView--;
                UpdateView();
            }
        }

        private void Error(string error)
        {
            errorPanel.SetError(error);
            _proceedToErrorView = true;
        }

        public bool TermsChanged(bool accepted)
        {
            if (_currentView != 1) return false;
            if (accepted)
            {
                _termsAccepted = true;
                nextButton.Enabled = true;
            }
            else
            {
                _termsAccepted = false;
                nextButton.Enabled = false;
            }
            return true;
        }

        public bool InstallOptionsChanged(bool canContinue)
        {
            if (_currentView != 2) return false;
            if (canContinue)
            {
                _canInstall = true;
                nextButton.Enabled = true;
            }
            else
            {
                _canInstall = false;
                nextButton.Enabled = false;
            }
            return true;
        }

        private void UpdateView()
        {
            switch (_currentView)
            {
                case 0: // Welcome
                    welcomePanel.Enabled = true;
                    licencePanel.Enabled = false;
                    optionsPanel.Enabled = false;
                    installPanel.Enabled = false;
                    completedPanel.Enabled = false;
                    errorPanel.Enabled = false;
                    welcomePanel.BringToFront();
                    backButton.Visible = false;
                    nextButton.Visible = true;
                    backButton.Enabled = true;
                    nextButton.Enabled = true;
                    nextButton.Text = "Next >";
                    break;
                case 1: // Licence
                    welcomePanel.Enabled = false;
                    licencePanel.Enabled = true;
                    optionsPanel.Enabled = false;
                    installPanel.Enabled = false;
                    completedPanel.Enabled = false;
                    errorPanel.Enabled = false;
                    licencePanel.BringToFront();
                    backButton.Enabled = true;
                    nextButton.Enabled = _termsAccepted;
                    backButton.Visible = true;
                    nextButton.Visible = true;
                    nextButton.Text = "Next >";
                    break;
                case 2: // Options
                    welcomePanel.Enabled = false;
                    licencePanel.Enabled = false;
                    optionsPanel.Enabled = true;
                    installPanel.Enabled = false;
                    completedPanel.Enabled = false;
                    errorPanel.Enabled = false;
                    optionsPanel.BringToFront();
                    optionsPanel.UpdateOptions();
                    backButton.Enabled = true;
                    nextButton.Enabled = _canInstall;
                    backButton.Visible = true;
                    nextButton.Visible = true;
                    nextButton.Text = "Next >";
                    break;
                case 3: // Install
                    welcomePanel.Enabled = false;
                    licencePanel.Enabled = false;
                    optionsPanel.Enabled = false;
                    installPanel.Enabled = true;
                    completedPanel.Enabled = false;
                    errorPanel.Enabled = false;
                    installPanel.BringToFront();
                    backButton.Enabled = true;
                    nextButton.Enabled = _canInstall;
                    backButton.Visible = true;
                    nextButton.Visible = true;
                    nextButton.Text = "Install";
                    break;
                case 4: // Completed
                    welcomePanel.Enabled = false;
                    licencePanel.Enabled = false;
                    optionsPanel.Enabled = false;
                    installPanel.Enabled = false;
                    completedPanel.Enabled = true;
                    errorPanel.Enabled = false;
                    completedPanel.BringToFront();
                    backButton.Visible = false;
                    nextButton.Visible = false;
                    break;
                case 5: // Error
                    welcomePanel.Enabled = false;
                    licencePanel.Enabled = false;
                    optionsPanel.Enabled = false;
                    installPanel.Enabled = false;
                    errorPanel.Enabled = true;
                    completedPanel.Enabled = true;
                    completedPanel.BringToFront();
                    backButton.Enabled = false;
                    nextButton.Enabled = true;
                    backButton.Visible = false;
                    nextButton.Visible = true;
                    nextButton.Text = "Retry";
                    break;
                default:
                    _currentView = 0;
                    goto case 0;
            }
        }

        private bool DoInternetCheck()
        {
            try
            {
                Ping myPing = new Ping();
                String host = "api.mullak99.co.uk";
                byte[] buffer = new byte[32];
                int timeout = 1000;
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                return reply != null && reply.Status == IPStatus.Success;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private string GetVerboseString()
        {
            if (Program.GetVerbose())
                return "--verbose --showinstalled --uver ";
            return "";
        }

        private bool InstallTools(string updaterPath)
        {
            List<bool> success = new List<bool>();
            Thread mainInstallThread = new Thread(() =>
            {
                if (String.IsNullOrWhiteSpace(updaterPath))
                    updaterPath = Path.Combine(Path.GetTempPath(), "FileAES", "Installer", "FAES-Updater.exe");

                string branch = "stable";

                BeginInvoke(new MethodInvoker(() =>
                {
                    switch (optionsPanel.GetBranchIndex())
                    {
                        case 0:
                            branch = "stable";
                            break;
                        case 1:
                            branch = "beta";
                            break;
                        case 2:
                            branch = "dev";
                            break;
                    }
                }));

                string[] toolsToInstall = optionsPanel.GetInstallList();

                if (toolsToInstall.Contains("FAES_GUI"))
                {
                    AppendToInstallLog("Starting install of 'FileAES'.");

                    Thread installThread = new Thread(() =>
                    {
                        string path = Path.Combine(optionsPanel.GetInstallPath(), "FileAES");

                        var p = new Process
                        {
                            StartInfo =
                            {
                                FileName = updaterPath,
                                Arguments = String.Format(
                                    "--directory \"{0}\" --tool faes_gui --preserve --branch {1} --fullinstall {2} {3}",
                                    path, branch, optionsPanel.CalculateFullInstallParams("FAES_GUI"),
                                    GetVerboseString()),
                                UseShellExecute = false,
                                CreateNoWindow = true,
                                RedirectStandardOutput = true
                            }
                        };
                        p.OutputDataReceived += SortOutputHandler;
                        p.Start();

                        p.BeginOutputReadLine();
                        p.WaitForExit();

                        success.Add(HandleExitCode(p.ExitCode));
                    });
                    installThread.Start();

                    while (installThread.IsAlive)
                        Thread.Sleep(100);

                    AppendToInstallLog("Finished installation of 'FileAES'!");
                }
                if (toolsToInstall.Contains("FAES_LEGACY"))
                {
                    AppendToInstallLog("Starting install of 'FileAES: Legacy'.");

                    Thread installThread = new Thread(() =>
                    {
                        string path = Path.Combine(optionsPanel.GetInstallPath(), "FileAES-Legacy");

                        var p = new Process();
                        p.StartInfo.FileName = updaterPath;
                        p.StartInfo.Arguments = String.Format("--directory \"{0}\" --tool faes_legacy --preserve --branch {1} --fullinstall {2} {3}", path, branch, optionsPanel.CalculateFullInstallParams("FAES_LEGACY"), GetVerboseString());
                        p.StartInfo.UseShellExecute = false;
                        p.StartInfo.CreateNoWindow = true;
                        p.StartInfo.RedirectStandardOutput = true;
                        p.OutputDataReceived += SortOutputHandler;
                        p.Start();

                        p.BeginOutputReadLine();
                        p.WaitForExit();

                        success.Add(HandleExitCode(p.ExitCode));
                    });
                    installThread.Start();

                    while (installThread.IsAlive)
                        Thread.Sleep(100);

                    AppendToInstallLog("Finished installation of 'FileAES: Legacy'!");
                }
                if (toolsToInstall.Contains("FAES_CLI"))
                {
                    AppendToInstallLog("Starting install of 'FileAES: CLI'.");

                    Thread installThread = new Thread(() =>
                    {
                        string path = Path.Combine(optionsPanel.GetInstallPath(), "FileAES-CLI");

                        var p = new Process();
                        p.StartInfo.FileName = updaterPath;
                        p.StartInfo.Arguments = String.Format("--directory \"{0}\" --tool faes_cli --preserve --branch {1} --fullinstall {2} {3}", path, branch, optionsPanel.CalculateFullInstallParams("FAES_CLI"), GetVerboseString());
                        p.StartInfo.UseShellExecute = false;
                        p.StartInfo.CreateNoWindow = true;
                        p.StartInfo.RedirectStandardOutput = true;
                        p.OutputDataReceived += SortOutputHandler;
                        p.Start();

                        p.BeginOutputReadLine();
                        p.WaitForExit();

                        success.Add(HandleExitCode(p.ExitCode));
                    });
                    installThread.Start();

                    while (installThread.IsAlive)
                        Thread.Sleep(100);

                    AppendToInstallLog("Finished installation of 'FileAES: CLI'!");
                }
                DeleteUpdater();
            });
            mainInstallThread.Start();

            while (mainInstallThread.IsAlive)
                Thread.SpinWait(10);

            if (success.Contains(false)) return false;
            return true;
        }

        private bool HandleExitCode(int updaterExitCode)
        {
            switch (updaterExitCode)
            {
                case 0:
                    // Success
                    if (Program.GetVerbose())
                        AppendToInstallLog("Updater exited with exit code 0 (Success).");
                    return true;
                case 1:
                    // Failed
                    if (Program.GetVerbose())
                        AppendToInstallLog("Updater exited with exit code 1 (Error).");
                    return false;
                case 2:
                    // Not Admin
                    if (Program.GetVerbose())
                        AppendToInstallLog("Updater exited with exit code 2 (Permission Denied).");
                    return false;
                default:
                    goto case 1;
            }
        }

        private void SortOutputHandler(object sender, DataReceivedEventArgs e)
        {
            Trace.WriteLine(e.Data);

            BeginInvoke(new MethodInvoker(() =>
            {
                AppendToInstallLog(e.Data ?? string.Empty);
            }));
        }

        private void AppendToInstallLog(string log)
        {
            BeginInvoke(new MethodInvoker(() =>
            {
                installPanel.GetInstallLog().AppendText(log + "\r\n");
            }));
        }

        private bool DownloadUpdater()
        {
            string webLink = String.Format("https://api.mullak99.co.uk/FAES/GetDownload.php?app=faes_updater&ver={0}&branch={1}", "latest", Program.GetUpdaterBranch());

            string fullPath = Path.Combine(Path.GetTempPath(), "FileAES", "Installer");

            if (Directory.Exists(fullPath))
                Directory.Delete(fullPath, true);

            if (!File.Exists(fullPath))
            {
                WebClient webClient = new WebClient();
                string downloadLink = webClient.DownloadString(new Uri(webLink));

                if (!String.IsNullOrWhiteSpace(downloadLink))
                {
                    Directory.CreateDirectory(Path.GetFullPath(fullPath));

                    string zipPath = Path.Combine(fullPath, "updater.zip");

                    if (File.Exists(zipPath)) File.Delete(zipPath);

                    webClient.DownloadFile(new Uri(downloadLink), zipPath);

                    if (File.Exists(zipPath))
                    {
                        ExtractUpdater(zipPath, fullPath);
                        return true;
                    }
                }
            }
            return false;
        }

        private void ExtractUpdater(string zipPath, string extractPath)
        {
            ZipFile.ExtractToDirectory(zipPath, extractPath);
            File.Delete(zipPath);
        }

        private void DeleteUpdater()
        {
            if (String.IsNullOrWhiteSpace(Program.GetUpdaterPath()))
            {
                try
                {
                    Directory.Delete(Path.Combine(Path.GetTempPath(), "FileAES", "Installer"), true);
                }
                catch
                {
                    // ignored
                }
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (_proceedToErrorView)
            {
                _currentView = 5;
                UpdateView();
            }
            else if (_currentView == 3 && nextButton.Text != "Next >")
            {
                Thread installHandlerThread = new Thread(() =>
                {
                    string updaterPath = Program.GetUpdaterPath();
                    if ((!String.IsNullOrWhiteSpace(updaterPath) && File.Exists(updaterPath)) || DownloadUpdater())
                    {
                        BeginInvoke(new MethodInvoker(() =>
                        {
                            nextButton.Enabled = false;
                            backButton.Enabled = false;
                        }));

                        if (InstallTools(updaterPath))
                        {
                            BeginInvoke(new MethodInvoker(() =>
                            {
                                nextButton.Text = "Next >";
                            }));
                        }
                        else
                            Error("An installation error occurred!");
                    }
                    else
                        Error("Could not download updater!");

                    nextButton.Enabled = true;
                    backButton.Enabled = false;
                });
                installHandlerThread.Start();
            }
            else if (_currentView == 5)
            {
                _currentView = 0;
                UpdateView();
            }
            else
                NextView();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            PreviousView();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            if (_currentView < 4 && MessageBox.Show("Are you sure you want to exit setup?", "Exit", MessageBoxButtons.YesNo) != DialogResult.Yes || _skipCloseCheck)
                e.Cancel = true;
        }
    }
}
