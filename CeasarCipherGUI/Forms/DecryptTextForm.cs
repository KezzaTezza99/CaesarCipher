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

namespace CeasarCipherGUI.Forms
{
    public partial class DecryptTextForm : Form
    {
        CaesarCipher caesarCipher = new CaesarCipher();

        public DecryptTextForm()
        {
            InitializeComponent();
            HideNonDefaultFields();
        }

        private void HideNonDefaultFields()
        {
            // Hiding some stuff by default until the user needs it
            dtfKeyLabel.Visible = false;
            dtfGetSuggestedKey.Visible = false;
            dtfCustomKeyCheckbox.Visible = false;
            dtfUsersCustomKey.Visible = false;
            dtfKeyValueLabel.Visible = false;
            dtfKeyValue.Visible = false;
            dtfDecryptedWordGuessLabel.Visible = false;
            dtfDecryptedWordGuessValue.Visible = false;
            dtfContinueDecryptionButton.Visible = false;
            dtfPlainTextOutput.Visible = false;
            dtfResetButton.Visible = false;
            dtfNoteLabel.Visible = false;
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
            caesarCipher.SetInputText(dtfEncryptedTextInput.Text);
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

            // Show the user the continue decrypting button
            dtfContinueDecryptionButton.Visible = true;

            // Show the warning about suggested key not being accurate
            dtfNoteLabel.Visible = true;
        }

        private void DecryptAllText(object sender, EventArgs e)
        {
            // Show the output and rest button
            dtfPlainTextOutput.Visible = true;
            dtfResetButton.Visible = true;

            // Set the key to be suggested key / or the user chosen key and then finish decrypting the text
            caesarCipher.SetInputText(dtfEncryptedTextInput.Text);

            // If the custom key isn't checked we just do this otherwise we need to ensure the key is changed!
            if (!dtfCustomKeyCheckbox.Checked)
            {
                caesarCipher.AnalysisOfText();
                caesarCipher.SetKeyToBeSuggestedKey();
                dtfPlainTextOutput.Text = caesarCipher.DecryptText();
            }
            else
            {
                caesarCipher.SetSuggestedKeyToUserDecidedKey((int)dtfUsersCustomKey.Value);
                caesarCipher.SetKeyToBeSuggestedKey();
                dtfPlainTextOutput.Text = caesarCipher.DecryptText();
            }
        }

        // Reset everything to allow the user to try again if needed
        private void ResetDecryptTextForm(object sender, EventArgs e)
        {
            // Rehiding fields
            HideNonDefaultFields();

            // Show the default fields and also reset all values
            ShowDefaultFields();
        }

        private void UseCustomKey(object sender, EventArgs e)
        {
            // If the box is checked show the custom key field otherwise don't
            if (dtfCustomKeyCheckbox.Checked)
            {
                dtfUsersCustomKey.Visible = true;

                // We should also update the suggested key to now be 1! 
                caesarCipher.SetSuggestedKeyToUserDecidedKey((int)dtfUsersCustomKey.Value);
                dtfKeyValue.Text = caesarCipher.GetSuggestedCipherKey().ToString();
                dtfDecryptedWordGuessValue.Text = caesarCipher.GetSuggestedDecipheredWord();
            }
            else
            {
                dtfUsersCustomKey.Visible = false;

                // Reset the numeric value to 1 incase the user had changed this
                dtfUsersCustomKey.Value = 1;

                // Reset the suggested key to be the analysis suggested key
                caesarCipher.AnalysisOfText();
                dtfKeyValue.Text = caesarCipher.GetSuggestedCipherKey().ToString();
                dtfDecryptedWordGuessValue.Text = caesarCipher.GetSuggestedDecipheredWord();
            }
        }

        private void GoToHomePage(object sender, EventArgs e)
        {
            NavigationHelper.NavigateHome(this);
        }

        private void UpdateSuggestedKeyValue(object sender, EventArgs e)
        {
            // User has chosen to use a custom key value so lets update the key and deciphered word!
            caesarCipher.SetSuggestedKeyToUserDecidedKey((int)dtfUsersCustomKey.Value);
            dtfDecryptedWordGuessValue.Text = caesarCipher.GetSuggestedDecipheredWord();
        }

        private void ShowOrHideGenerateKey(object sender, EventArgs e)
        {
            // Instead of error handling the input text being empty, just don't allow them to generate a cipher
            // untill a value is in the input field
            if (string.IsNullOrWhiteSpace(dtfEncryptedTextInput.Text))
            {
                dtfGetSuggestedKey.Visible = false;
                dtfKeyLabel.Visible = false;
            }
            else
            {
                dtfGetSuggestedKey.Visible = true;
                dtfKeyLabel.Visible = true;
            }
        }
    }
}