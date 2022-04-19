using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace FileAES_Installer
{
    public partial class Uninstaller : Form
    {
        private bool _skipCloseCheck;

        private Func<bool, bool> _runOnClose;

        public Uninstaller()
        {
            InitializeComponent();
            InternetCheck();

            Utils.GetSoftwareFilePaths(out List<string> toolNames);

            if (toolNames.Count > 0)
            {
                uninstallButton.Enabled = true;
                detectedToolsLabel.Text = string.Join("\r\n", Utils.ConvertSoftwareNamesToFormatted(toolNames.ToArray()));
            }
            else
            {
                uninstallButton.Enabled = false;
            }
        }

        public void SetRunOnClose(Func<bool, bool> run)
        {
            _runOnClose = run;
        }

        private void InternetCheck()
        {
            if (!Utils.DoInternetCheck())
            {
                if (MessageBox.Show("Could not connect to the update server!\r\n\r\nPlease ensure you have an internet connection.", "FileAES: Uninstaller | Connection Error", MessageBoxButtons.RetryCancel) == DialogResult.Retry)
                    InternetCheck();
                else
                {
                    _skipCloseCheck = true;
                    Close();
                }
            }
        }

        private bool Uninstall(string updaterPath)
        {
            if (string.IsNullOrWhiteSpace(updaterPath))
                updaterPath = Path.Combine(Path.GetTempPath(), "FileAES", "Uninstaller", "FAES-Updater.exe");

            bool success = false;
            Thread uninstallThread = new Thread(() =>
            {
                var p = new Process
                {
                    StartInfo =
                    {
                        FileName = updaterPath,
                        Arguments = $"--preserve --uninstall {GetDeleteUserDataString()} {GetVerboseString()}",
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        RedirectStandardOutput = true
                    }
                };
                //p.OutputDataReceived += SortOutputHandler;
                p.Start();

                //p.BeginOutputReadLine();
                p.WaitForExit();

                success = HandleExitCode(p.ExitCode);
            });
            uninstallThread.Start();

            while (uninstallThread.IsAlive)
                Thread.SpinWait(10);

            DeleteUpdater();

            if (success)
                MessageBox.Show("FileAES was uninstalled successfully!", "Uninstall Completed", MessageBoxButtons.OK);
            else if (MessageBox.Show("FileAES could not be uninstalled!", "Uninstall Failed", MessageBoxButtons.RetryCancel) == DialogResult.Retry)
                    Uninstall(updaterPath);

            return success;
        }

        private bool HandleExitCode(int updaterExitCode)
        {
            switch (updaterExitCode)
            {
                case 0:
                    // Success
                    return true;
                case 1:
                    // Failed
                    return false;
                case 2:
                    // Not Admin
                    return false;
                default:
                    goto case 1;
            }
        }

        private string GetDeleteUserDataString()
        {
            if (deleteUserDataCheckBox.Checked)
                return "--deleteuserdata ";
            return "";
        }

        private string GetVerboseString()
        {
            if (Program.GetVerbose())
                return "--verbose --showinstalled --uver ";
            return "";
        }

        private bool DownloadUpdater()
        {
            string webLink = $"https://api.mullak99.co.uk/FAES/GetDownload.php?app=faes_updater&ver={"latest"}&branch={Program.GetUpdaterBranch()}";

            string fullPath = Path.Combine(Path.GetTempPath(), "FileAES", "Uninstaller");

            if (Directory.Exists(fullPath))
                Directory.Delete(fullPath, true);

            if (!File.Exists(fullPath))
            {
                WebClient webClient = new WebClient();
                string downloadLink = webClient.DownloadString(new Uri(webLink));

                if (!string.IsNullOrWhiteSpace(downloadLink))
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
            if (string.IsNullOrWhiteSpace(Program.GetUpdaterPath()))
            {
                try
                {
                    Directory.Delete(Path.Combine(Path.GetTempPath(), "FileAES", "Uninstaller"), true);
                }
                catch
                {
                    // ignored
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uninstallButton_Click(object sender, EventArgs e)
        {
            if (uninstallButton.Text != "Close")
            {
                string updaterPath = Program.GetUpdaterPath();
                if ((!string.IsNullOrWhiteSpace(updaterPath) && File.Exists(updaterPath)) || DownloadUpdater())
                {
                    if (Uninstall(updaterPath))
                    {
                        uninstallButton.Text = "Close";
                        _skipCloseCheck = true;
                    }
                }
            }
            else
                Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            if (!_skipCloseCheck)
                if (MessageBox.Show("Are you sure you want to exit the uninstaller?", "Exit", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    e.Cancel = true;

            _runOnClose?.Invoke(true);
        }
    }
}
