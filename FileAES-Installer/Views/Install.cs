using System.Windows.Forms;

namespace FileAES_Installer.Views
{
    public partial class Install : UserControl
    {
        public Install()
        {
            InitializeComponent();
        }

        public RichTextBox GetInstallLog()
        {
            return installLog;
        }
    }
}
