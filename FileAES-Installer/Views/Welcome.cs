using System;
using System.Windows.Forms;

namespace FileAES_Installer.Views
{
    public partial class Welcome : UserControl
    {
        public Welcome()
        {
            InitializeComponent();

            infoLabel.Text = String.Format("{0}\r\n{1}\r\n\r\nCopyright © mullak99 - 2021", Program.GetVersion(), ShowDebugInfo());
        }

        private string ShowDebugInfo()
        {
            if (Program.GetVerbose())
            {
                string returnVal = "\r\n== DEBUG INFO ==\r\n";
                if (!String.IsNullOrWhiteSpace(Program.GetUpdaterPath()))
                    returnVal += String.Format("Updater: {0}\r\n", Program.GetUpdaterPath());
                else
                    returnVal += String.Format("Updater: {0}\r\n", Program.GetUpdaterBranch().ToUpper());

                return returnVal;
            }
            return "";
        }
    }
}
