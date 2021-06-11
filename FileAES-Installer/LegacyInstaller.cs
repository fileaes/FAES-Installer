using System;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Windows.Forms;

namespace FileAES_Installer
{
    public partial class LegacyInstaller : Form
    {
        public LegacyInstaller()
        {
            InitializeComponent();
            toolInstall_CheckedChanged(null, null);
            branchComboBox.SelectedIndex = branchComboBox.Items.Count - 1;
            versionLabel.Text = Program.GetVersion();

            installDir.Text = Path.Combine(Environment.ExpandEnvironmentVariables("%ProgramFiles(x86)%"), "mullak99", "FileAES");

            if (Program.GetVerbose())
            {
                devInfo.Visible = true;
                devInfoTextBox.Text = String.Format("Version: {0}\r\nUpdaterPath: {1}", Program.GetVersion(),
                    Program.GetUpdaterPath());
            }
        }

        private void passAccept_CheckedChanged(object sender, EventArgs e)
        {
            installButton.Enabled = true;
        }

        private void failAccept_CheckedChanged(object sender, EventArgs e)
        {
            installButton.Enabled = false;
        }

        private void installButton_Click(object sender, EventArgs e)
        {
            string updaterPath = Program.GetUpdaterPath();
            if ((!String.IsNullOrWhiteSpace(updaterPath) && File.Exists(updaterPath)) || DownloadUpdater())
            {
                InstallTools(toolInstallFileAES.Checked, toolInstallFileAESLegacy.Checked, toolInstallFileAESCLI.Checked, updaterPath);
                MessageBox.Show("Installation Successful!", "Installer", MessageBoxButtons.OK);
            }
            else
            {
                if (MessageBox.Show("Installation Failed!", "Installer", MessageBoxButtons.RetryCancel) == DialogResult.Retry)
                    installButton_Click(sender, e);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private string CalculateFullInstallParams(string tool)
        {
            string returnString = "";

            if (tool == defaultToolComboBox.Text)
            {
                if (fileAssociation.Checked)
                    returnString += "--associatefiletypes ";
                if (addToContext.Checked)
                    returnString += "--contextmenus ";
            }
            if (addToStartMenu.Checked)
                returnString += "--startmenushortcuts ";
            
            return returnString;
        }

        private string GetVerboseString()
        {
            if (Program.GetVerbose())
                return "--verbose ";
            return "--headless ";
        }

        private void InstallTools(bool FAESGUI, bool FAESLEGACY, bool FAESCLI, string updaterPath)
        {
            if (String.IsNullOrWhiteSpace(updaterPath))
                updaterPath = Path.Combine(Path.GetTempPath(), "FileAES", "Installer", "FAES-Updater.exe");

            string branch = "stable";

            switch (branchComboBox.SelectedIndex)
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

            if (FAESGUI)
            {
                string path = Path.Combine(installDir.Text, "FileAES");

                var p = new System.Diagnostics.Process();
                p.StartInfo.FileName = updaterPath;
                p.StartInfo.Arguments = String.Format("--directory \"{0}\" --tool faes_gui --preserve --branch {1} --fullinstall {2} {3}", path, branch, CalculateFullInstallParams("FileAES"), GetVerboseString());
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.CreateNoWindow = true;
                p.Start();
            }
            if (FAESLEGACY)
            {
                string path = Path.Combine(installDir.Text, "FileAES-Legacy");

                var p = new System.Diagnostics.Process();
                p.StartInfo.FileName = updaterPath;
                p.StartInfo.Arguments = String.Format("--directory \"{0}\" --tool faes_legacy --preserve --branch {1} --fullinstall {2} {3}", path, branch, CalculateFullInstallParams("FileAES-Legacy"), GetVerboseString());
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.CreateNoWindow = true;
                p.Start();

            }
            if (FAESCLI)
            {
                string path = Path.Combine(installDir.Text, "FileAES-CLI");

                var p = new System.Diagnostics.Process();
                p.StartInfo.FileName = updaterPath;
                p.StartInfo.Arguments = String.Format("--directory \"{0}\" --tool faes_cli --preserve --branch {1} --fullinstall {2} {3}", path, branch, CalculateFullInstallParams("FileAES-CLI"), GetVerboseString());
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.CreateNoWindow = true;
                p.Start();
            }
            DeleteUpdater();
        }

        private bool DownloadUpdater()
        {
            string webLink = String.Format("https://api.mullak99.co.uk/FAES/GetDownload.php?app=faes_updater&ver={0}&branch={1}", "latest", "stable");

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

        private bool DeleteUpdater()
        {
            try
            {
                Directory.Delete(Path.Combine(Path.GetTempPath(), "FileAES", "Installer"), true);
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        private void toolInstall_CheckedChanged(object sender, EventArgs e)
        {
            defaultToolComboBox.Items.Clear();
            if (toolInstallFileAES.Checked || toolInstallFileAESCLI.Checked || toolInstallFileAESLegacy.Checked)
            {
                defaultToolComboBox.Enabled = true;

                if (toolInstallFileAES.Checked)
                {
                    defaultToolComboBox.Items.Add("FileAES");
                }
                if (toolInstallFileAESLegacy.Checked)
                {
                    defaultToolComboBox.Items.Add("FileAES-Legacy");
                }
                if (toolInstallFileAESCLI.Checked)
                {
                    defaultToolComboBox.Items.Add("FileAES-CLI");
                }

                defaultToolComboBox.SelectedIndex = 0;
            }
            else
            {
                defaultToolComboBox.Enabled = false;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            DeleteUpdater();

            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

        }
    }
}
