using CeasarCipherGUI.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CeasarCipherGUI
{
    public partial class EncryptTextForm : Form
    {
        CaesarCipher caesarCipher = new CaesarCipher();

        public EncryptTextForm()
        {
            InitializeComponent();
            etfEncryptedTextOutput.Visible = false;
        }

        private void EncryptText(object sender, EventArgs e)
        {
            // Display the encrypted text field area
            etfEncryptedTextOutput.Visible = true;

            // Create the cipher object and pass in the plain text and the users key choice
            caesarCipher.SetInputText(etfPlainTextInput.Text);
            caesarCipher.SetCipherKey((int)etfCipherKey.Value);

            // Encrypt the text and display the output in the text area field
            etfEncryptedTextOutput.Text = caesarCipher.EncryptText();
        }

        private void GoToHomePage(object sender, EventArgs e)
        {
            NavigationHelper.NavigateHome(this);
        }
    }
}