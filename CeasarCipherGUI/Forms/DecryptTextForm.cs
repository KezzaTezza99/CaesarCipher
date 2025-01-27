using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CeasarCipherGUI.Forms
{
    public partial class DecryptTextForm : Form
    {
        public DecryptTextForm()
        {
            InitializeComponent();
            HideNonDefaultFields();
        }

        private void HideNonDefaultFields()
        {
            // Hiding some stuff by default until the user needs it
            dtfCustomKeyCheckbox.Visible = false;
            dtfUsersCustomKey.Visible = false;
            dtfKeyValueLabel.Visible = false;
            dtfKeyValue.Visible = false;
            dtfDecryptedWordGuessLabel.Visible = false;
            dtfDecryptedWordGuessValue.Visible = false;
            dtfContinueDecryptionButton.Visible = false;
            dtfPlainTextOutput.Visible = false;
            dtfResetButton.Visible = false;
        }

        private void ShowDefaultFields()
        {
            dtfKeyLabel.Visible = true;
            dtfGetSuggestedKey.Visible = true;
            dtfCustomKeyCheckbox.Checked = false;
            dtfUsersCustomKey.Value = 1;
            dtfPlainTextOutput.Text = string.Empty;
        }

        private void AnalysisTextForKey(object sender, EventArgs e)
        {
            // Now actually get the analysis key value
            //TODO: NOT DRY CODE WE REPEAT 
            CaesarCipher caesarCipher = new CaesarCipher(dtfEncryptedTextInput.Text);
            caesarCipher.AnalysisOfText();

            // Hide the button as we don't need to generate the key anymore
            dtfGetSuggestedKey.Visible = false;
            dtfKeyLabel.Visible = false;

            // Show the user the suggested key
            dtfKeyValueLabel.Visible = true;
            dtfKeyValue.Visible = true;
            dtfKeyValue.Text = caesarCipher.GetSuggestedCipherKey().ToString();

            // Show the user what the first word would be with decryption ran using the key
            dtfDecryptedWordGuessLabel.Visible = true;
            dtfDecryptedWordGuessValue.Visible = true;
            dtfDecryptedWordGuessValue.Text = caesarCipher.GetSuggestedDecipheredWord();

            // Show the user the custom key input incase they want to use it!
            dtfCustomKeyCheckbox.Visible = true;
            dtfUsersCustomKey.Visible = true;

            // Show the user the continue decrypting button
            dtfContinueDecryptionButton.Visible = true;
        }

        private void DecryptAllText(object sender, EventArgs e)
        {
            // Show the output and rest button
            dtfPlainTextOutput.Visible = true;
            dtfResetButton.Visible = true;

            // Set the key to be suggested key / or the user chosen key and then finish decrypting the text
            CaesarCipher caesarCipher = new CaesarCipher(dtfEncryptedTextInput.Text);
            caesarCipher.AnalysisOfText();
            caesarCipher.SetKeyToBeSuggestedKey();
            dtfPlainTextOutput.Text = caesarCipher.DecryptText();
        }

        // Reset everything to allow the user to try again if needed
        private void ResetDecryptTextForm(object sender, EventArgs e)
        {
            // Rehiding fields
            HideNonDefaultFields();

            // Show the default fields and also reset all values
            ShowDefaultFields();
        }
    }
}
