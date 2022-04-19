using System.Windows.Forms;

namespace FileAES_Installer.Views
{
    public partial class Error : UserControl
    {
        public Error()
        {
            InitializeComponent();
            errorLabel.Text = "";
        }

        public Error(string error) : this()
        {
            SetError(error);
        }

        public void SetError(string error)
        {
            errorLabel.Text = error;
        }
    }
}
