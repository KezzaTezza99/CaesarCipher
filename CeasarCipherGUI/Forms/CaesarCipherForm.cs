using CeasarCipherGUI.Forms;
using CeasarCipherGUI.Utility;

namespace CeasarCipherGUI
{
    public partial class CaesarCipherForm : Form
    {
        public CaesarCipherForm()
        {
            InitializeComponent();
        }

        private void EncryptTextClicked(object sender, EventArgs e)
        {
            EncryptTextForm encryptFileForm = new EncryptTextForm();
            NavigationHelper.NavigateToNewPageFromHome(this, encryptFileForm);
        }

        private void DecryptTextClicked(object sender, EventArgs e)
        {
            DecryptTextForm decryptFileForm = new DecryptTextForm();
            NavigationHelper.NavigateToNewPageFromHome(this, decryptFileForm);
        }
    }
}