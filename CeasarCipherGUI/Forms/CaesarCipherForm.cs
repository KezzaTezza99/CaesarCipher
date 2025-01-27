using CeasarCipherGUI.Forms;

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

            // Ensuring that we can exit the application from EncryptFileForm!
            encryptFileForm.FormClosed += (s, args) => Application.Exit();

            this.Hide();                                    // Hiding the initial Form (main menu)
            encryptFileForm.Show();                         // Showing the EncryptFileForm
        }

        private void DecryptTextClicked(object sender, EventArgs e)
        {
            DecryptTextForm decryptFileForm = new DecryptTextForm();

            // Ensuring that we can exit the application from DecryptTextForm!
            decryptFileForm.FormClosed += (s, args) => Application.Exit();

            this.Hide();                                    // Hiding the initial Form (main menu)
            decryptFileForm.Show();                         // Showing the DecryptTextForm
        }
    }
}