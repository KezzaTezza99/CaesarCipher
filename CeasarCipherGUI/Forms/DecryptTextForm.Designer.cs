namespace CeasarCipherGUI.Forms
{
    partial class DecryptTextForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtfLabel = new Label();
            dtfEncryptedTextInput = new RichTextBox();
            dtfGetSuggestedKey = new Button();
            dtfKeyLabel = new Label();
            dtfCustomKeyCheckbox = new CheckBox();
            dtfUsersCustomKey = new NumericUpDown();
            dtfKeyValueLabel = new Label();
            dtfKeyValue = new Label();
            dtfDecryptedWordGuessLabel = new Label();
            dtfDecryptedWordGuessValue = new Label();
            dtfContinueDecryptionButton = new Button();
            dtfPlainTextOutput = new RichTextBox();
            dtfResetButton = new Button();
            dtfHome = new Button();
            ((System.ComponentModel.ISupportInitialize)dtfUsersCustomKey).BeginInit();
            SuspendLayout();
            // 
            // dtfLabel
            // 
            dtfLabel.AutoSize = true;
            dtfLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            dtfLabel.ForeColor = Color.White;
            dtfLabel.Location = new Point(230, 10);
            dtfLabel.Name = "dtfLabel";
            dtfLabel.Size = new Size(330, 17);
            dtfLabel.TabIndex = 0;
            dtfLabel.Text = "Enter the encrypted text below to begin decryption!";
            // 
            // dtfEncryptedTextInput
            // 
            dtfEncryptedTextInput.Location = new Point(16, 30);
            dtfEncryptedTextInput.Name = "dtfEncryptedTextInput";
            dtfEncryptedTextInput.Size = new Size(776, 84);
            dtfEncryptedTextInput.TabIndex = 2;
            dtfEncryptedTextInput.Text = "";
            // 
            // dtfGetSuggestedKey
            // 
            dtfGetSuggestedKey.Location = new Point(376, 120);
            dtfGetSuggestedKey.Name = "dtfGetSuggestedKey";
            dtfGetSuggestedKey.Size = new Size(103, 32);
            dtfGetSuggestedKey.TabIndex = 3;
            dtfGetSuggestedKey.Text = "Generate Key";
            dtfGetSuggestedKey.UseVisualStyleBackColor = true;
            dtfGetSuggestedKey.Click += AnalysisTextForKey;
            // 
            // dtfKeyLabel
            // 
            dtfKeyLabel.AutoSize = true;
            dtfKeyLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtfKeyLabel.ForeColor = Color.White;
            dtfKeyLabel.Location = new Point(16, 127);
            dtfKeyLabel.Name = "dtfKeyLabel";
            dtfKeyLabel.Size = new Size(354, 17);
            dtfKeyLabel.TabIndex = 4;
            dtfKeyLabel.Text = "Analysis text to get a suggested key to decipher the text";
            // 
            // dtfCustomKeyCheckbox
            // 
            dtfCustomKeyCheckbox.AutoSize = true;
            dtfCustomKeyCheckbox.ForeColor = Color.White;
            dtfCustomKeyCheckbox.Location = new Point(668, 120);
            dtfCustomKeyCheckbox.Name = "dtfCustomKeyCheckbox";
            dtfCustomKeyCheckbox.Size = new Size(124, 19);
            dtfCustomKeyCheckbox.TabIndex = 6;
            dtfCustomKeyCheckbox.Text = "Use your own key?";
            dtfCustomKeyCheckbox.UseVisualStyleBackColor = true;
            // 
            // dtfUsersCustomKey
            // 
            dtfUsersCustomKey.Location = new Point(668, 145);
            dtfUsersCustomKey.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            dtfUsersCustomKey.Name = "dtfUsersCustomKey";
            dtfUsersCustomKey.Size = new Size(120, 23);
            dtfUsersCustomKey.TabIndex = 7;
            dtfUsersCustomKey.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // dtfKeyValueLabel
            // 
            dtfKeyValueLabel.AutoSize = true;
            dtfKeyValueLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtfKeyValueLabel.ForeColor = Color.White;
            dtfKeyValueLabel.Location = new Point(16, 128);
            dtfKeyValueLabel.Name = "dtfKeyValueLabel";
            dtfKeyValueLabel.Size = new Size(73, 17);
            dtfKeyValueLabel.TabIndex = 8;
            dtfKeyValueLabel.Text = "Key Value: ";
            // 
            // dtfKeyValue
            // 
            dtfKeyValue.AutoSize = true;
            dtfKeyValue.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtfKeyValue.ForeColor = Color.White;
            dtfKeyValue.Location = new Point(85, 128);
            dtfKeyValue.Name = "dtfKeyValue";
            dtfKeyValue.Size = new Size(0, 17);
            dtfKeyValue.TabIndex = 9;
            // 
            // dtfDecryptedWordGuessLabel
            // 
            dtfDecryptedWordGuessLabel.AutoSize = true;
            dtfDecryptedWordGuessLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtfDecryptedWordGuessLabel.ForeColor = Color.White;
            dtfDecryptedWordGuessLabel.Location = new Point(16, 151);
            dtfDecryptedWordGuessLabel.Name = "dtfDecryptedWordGuessLabel";
            dtfDecryptedWordGuessLabel.Size = new Size(175, 17);
            dtfDecryptedWordGuessLabel.TabIndex = 10;
            dtfDecryptedWordGuessLabel.Text = "Decrypted word using key: ";
            // 
            // dtfDecryptedWordGuessValue
            // 
            dtfDecryptedWordGuessValue.AutoSize = true;
            dtfDecryptedWordGuessValue.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtfDecryptedWordGuessValue.ForeColor = Color.White;
            dtfDecryptedWordGuessValue.Location = new Point(195, 151);
            dtfDecryptedWordGuessValue.Name = "dtfDecryptedWordGuessValue";
            dtfDecryptedWordGuessValue.Size = new Size(0, 17);
            dtfDecryptedWordGuessValue.TabIndex = 11;
            // 
            // dtfContinueDecryptionButton
            // 
            dtfContinueDecryptionButton.Location = new Point(16, 171);
            dtfContinueDecryptionButton.Name = "dtfContinueDecryptionButton";
            dtfContinueDecryptionButton.Size = new Size(124, 32);
            dtfContinueDecryptionButton.TabIndex = 12;
            dtfContinueDecryptionButton.Text = "Finish Decryption";
            dtfContinueDecryptionButton.UseVisualStyleBackColor = true;
            dtfContinueDecryptionButton.Click += DecryptAllText;
            // 
            // dtfPlainTextOutput
            // 
            dtfPlainTextOutput.Location = new Point(16, 209);
            dtfPlainTextOutput.Name = "dtfPlainTextOutput";
            dtfPlainTextOutput.Size = new Size(776, 173);
            dtfPlainTextOutput.TabIndex = 13;
            dtfPlainTextOutput.Text = "";
            // 
            // dtfResetButton
            // 
            dtfResetButton.Location = new Point(16, 388);
            dtfResetButton.Name = "dtfResetButton";
            dtfResetButton.Size = new Size(124, 32);
            dtfResetButton.TabIndex = 14;
            dtfResetButton.Text = "Reset";
            dtfResetButton.UseVisualStyleBackColor = true;
            dtfResetButton.Click += ResetDecryptTextForm;
            // 
            // dtfHome
            // 
            dtfHome.Location = new Point(668, 388);
            dtfHome.Name = "dtfHome";
            dtfHome.Size = new Size(124, 32);
            dtfHome.TabIndex = 15;
            dtfHome.Text = "Home";
            dtfHome.UseVisualStyleBackColor = true;
            // 
            // DecryptTextForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(804, 477);
            Controls.Add(dtfHome);
            Controls.Add(dtfResetButton);
            Controls.Add(dtfPlainTextOutput);
            Controls.Add(dtfContinueDecryptionButton);
            Controls.Add(dtfDecryptedWordGuessValue);
            Controls.Add(dtfDecryptedWordGuessLabel);
            Controls.Add(dtfKeyValue);
            Controls.Add(dtfKeyValueLabel);
            Controls.Add(dtfUsersCustomKey);
            Controls.Add(dtfCustomKeyCheckbox);
            Controls.Add(dtfKeyLabel);
            Controls.Add(dtfGetSuggestedKey);
            Controls.Add(dtfEncryptedTextInput);
            Controls.Add(dtfLabel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "DecryptTextForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Decrypt Text";
            ((System.ComponentModel.ISupportInitialize)dtfUsersCustomKey).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label dtfLabel;
        private RichTextBox dtfEncryptedTextInput;
        private Button dtfGetSuggestedKey;
        private Label dtfKeyLabel;
        private CheckBox dtfCustomKeyCheckbox;
        private NumericUpDown dtfUsersCustomKey;
        private Label dtfKeyValueLabel;
        private Label dtfKeyValue;
        private Label dtfDecryptedWordGuessLabel;
        private Label dtfDecryptedWordGuessValue;
        private Button dtfContinueDecryptionButton;
        private RichTextBox dtfPlainTextOutput;
        private Button dtfResetButton;
        private Button dtfHome;
    }
}