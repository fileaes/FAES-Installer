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
    public partial class Setup : Form
    {

        public Setup()
        {
            InitializeComponent();

            Utils.GetSoftwareFilePaths(out List<string> toolNames);

            if (toolNames.Count > 0)
            {
                detectedToolsLabel.Text = string.Join("\r\n", Utils.ConvertSoftwareNamesToFormatted(toolNames.ToArray()));
            }
        }

        private bool CloseApp(bool close)
        {
            if (close) Close();
            return close;
        }

        private void installButton_Click(object sender, EventArgs e)
        {
            Installer installer = new Installer();
            installer.Show();
            installer.SetRunOnClose(CloseApp);
        }

        private void uninstallButton_Click(object sender, EventArgs e)
        {
            Uninstaller uninstaller = new Uninstaller();
            uninstaller.Show();
            uninstaller.SetRunOnClose(CloseApp);
        }
    }
}
