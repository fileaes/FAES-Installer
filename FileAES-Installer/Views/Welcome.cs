using System.Windows.Forms;

namespace FileAES_Installer.Views
{
    public partial class Welcome : UserControl
    {
        public Welcome()
        {
            InitializeComponent();

            infoLabel.Text = $"{Program.GetVersion()}\r\n{ShowDebugInfo()}\r\n\r\nCopyright © mullak99 - 2022";
        }

        private string ShowDebugInfo()
        {
            if (Program.GetVerbose())
            {
                string returnVal = "\r\n== DEBUG INFO ==\r\n";
                if (!string.IsNullOrWhiteSpace(Program.GetUpdaterPath()))
                    returnVal += $"Updater: {Program.GetUpdaterPath()}\r\n";
                else
                    returnVal += $"Updater: {Program.GetUpdaterBranch().ToUpper()}\r\n";

                return returnVal;
            }
            return "";
        }
    }
}
