using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace FileAES_Installer.Views
{
    public partial class Options : UserControl
    {
        private Func<bool, bool> _canContinue;
        private bool _doneUpdate;

        public Options()
        {
            InitializeComponent();
            installPath.Text = Path.Combine(Environment.ExpandEnvironmentVariables("%ProgramFiles(x86)%"), "mullak99", "FileAES");
            branchComboBox.SelectedIndex = 2;
        }

        public void UpdateOptions()
        {
            if (!_doneUpdate)
            {
                for (int i = 0; i < toolsCheckList.Items.Count; i++)
                    toolsCheckList.SetItemChecked(i, true);

                for (int i = 0; i < installOptionsCheckList.Items.Count; i++)
                    installOptionsCheckList.SetItemChecked(i, true);

                _doneUpdate = true;
            }
            toolsCheckList_SelectedIndexChanged(null, null);
        }

        public void SetCanInstallContinue(Func<bool, bool> installContinue)
        {
            _canContinue = installContinue;
        }

        private void DoContinueCheck(bool areItemsChecked)
        {
            if (areItemsChecked)
            {
                try
                {
                    // ReSharper disable once UnusedVariable
                    string fullPath = Path.GetFullPath(installPath.Text);
                    _canContinue(true);
                    return;
                }
                catch
                {
                    // ignored
                }
            }
            _canContinue(false);
        }

        public string GetInstallPath()
        {
            return installPath.Text;
        }

        public string[] GetInstallList()
        {
            List<string> checkedTools = new List<string>(3);
            for (int i = 0; i < toolsCheckList.Items.Count; i++)
            {
                switch (i)
                {
                    case 0:
                        checkedTools.Add("FAES_GUI");
                        break;
                    case 1:
                        checkedTools.Add("FAES_LEGACY");
                        break;
                    case 2:
                        checkedTools.Add("FAES_CLI");
                        break;
                }
            }
            return checkedTools.ToArray();
        }

        public int GetBranchIndex()
        {
            return branchComboBox.SelectedIndex;
        }

        public string CalculateFullInstallParams(string tool)
        {
            string returnString = "";

            for (int i = 0; i < installOptionsCheckList.Items.Count; i++)
            {
                if (installOptionsCheckList.GetItemCheckState(i) == CheckState.Checked)
                {
                    switch (i)
                    {
                        case 0:
                            if (tool.ToUpper() == GetDefaultToolName()) returnString += "--associatefiletypes ";
                            break;
                        case 1:
                            returnString += "--startmenushortcuts ";
                            break;
                        case 2:
                            if (tool.ToUpper() == GetDefaultToolName()) returnString += "--contextmenus ";
                            break;
                    }
                }
            }
            return returnString;
        }

        private string GetDefaultToolName()
        {
            string selected = "";
            BeginInvoke(new MethodInvoker(() =>
            {
                selected = defaultToolComboBox.SelectedItem.ToString().ToUpper();
            }));

            if (!string.IsNullOrWhiteSpace(selected))
            {
                switch (selected)
                {
                    default:
                        return "FAES_GUI";
                    case "FILEAES: LEGACY":
                        return "FAES_LEGACY";
                    case "FILEAES: CLI":
                        return "FAES_CLI";
                }
            }
            return "FAES_GUI";
        }

        private void toolsCheckList_SelectedIndexChanged(object sender, EventArgs e)
        {
            defaultToolComboBox.Items.Clear();

            if (toolsCheckList.CheckedItems.Count > 0)
            {
                defaultToolComboBox.Enabled = true;

                foreach (var item in toolsCheckList.CheckedItems)
                    defaultToolComboBox.Items.Add(item.ToString());

                defaultToolComboBox.SelectedIndex = 0;

                DoContinueCheck(true);
            }
            else
            {
                defaultToolComboBox.Enabled = false;
                DoContinueCheck(false);
            }
        }

        private void folderFindButton_Click(object sender, EventArgs e)
        {
            Thread folderThread = new Thread(() =>
            {
                using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog
                {
                    Description = "Install directory for FileAES Tool(s)",
                    SelectedPath = installPath.Text
                })
                {
                    if (folderBrowser.ShowDialog() == DialogResult.OK)
                    {
                        string path = folderBrowser.SelectedPath;
                        Invoke(new Action(() =>
                        {
                            installPath.Text = Path.GetFullPath(path);
                        }));
                    }
                }
            });
            folderThread.SetApartmentState(ApartmentState.STA);
            folderThread.Start();
        }
    }
}
