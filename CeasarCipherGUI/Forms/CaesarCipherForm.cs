namespace CeasarCipherGUI
{
    public partial class CaesarCipherForm : Form
    {
        public CaesarCipherForm()
        {
            InitializeComponent();
        }

        private void encryptTextButton_Click(object sender, EventArgs e)
        {
            EncryptTextForm encryptFileForm = new EncryptTextForm();
            
            // Ensuring that we can exit the application from EncryptFileForm!
            encryptFileForm.FormClosed += (s, args) => Application.Exit();

            this.Hide();                                    // Hiding the initial Form (main menu)
            encryptFileForm.Show();                         // Showing the EncryptFileForm
        }
    }
}