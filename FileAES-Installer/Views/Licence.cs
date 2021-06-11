using System;
using System.Windows.Forms;

namespace FileAES_Installer.Views
{
    public partial class Licence : UserControl
    {
        private Func<bool, bool> _onLicenceUpdate;

        public Licence()
        {
            InitializeComponent();
        }

        public void SetOnLicenceUpdate(Func<bool, bool> updateLicence)
        {
            _onLicenceUpdate = updateLicence;
        }

        private void acceptTerms_CheckedChanged(object sender, EventArgs e)
        {
            if (denyTerms.Checked && acceptTerms.Checked) denyTerms.Checked = false;
            _onLicenceUpdate(acceptTerms.Checked);
        }

        private void denyTerms_CheckedChanged(object sender, EventArgs e)
        {
            if (denyTerms.Checked && acceptTerms.Checked) acceptTerms.Checked = false;
            _onLicenceUpdate(acceptTerms.Checked);
        }
    }
}
