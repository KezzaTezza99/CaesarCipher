namespace CeasarCipherGUI
{
    partial class CaesarCipherForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            encryptTextButton = new Button();
            welcomeLabel = new Label();
            decryptTextButton = new Button();
            encryptFileButton = new Button();
            decryptFileButton = new Button();
            extraInfoLabel = new Label();
            SuspendLayout();
            // 
            // encryptTextButton
            // 
            encryptTextButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            encryptTextButton.ForeColor = SystemColors.ActiveCaptionText;
            encryptTextButton.Location = new Point(47, 112);
            encryptTextButton.Name = "encryptTextButton";
            encryptTextButton.Size = new Size(136, 44);
            encryptTextButton.TabIndex = 0;
            encryptTextButton.Text = "Encrypt Text";
            encryptTextButton.UseVisualStyleBackColor = true;
            encryptTextButton.Click += EncryptTextClicked;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            welcomeLabel.Location = new Point(12, 28);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(769, 40);
            welcomeLabel.TabIndex = 1;
            welcomeLabel.Text = "This program's main purpose is to encrypt plain text using a Caesar Cipher. \r\nHowever, it can also be used in reverse to get plain text from an already encrypted message using a Caesar Cipher. ";
            welcomeLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // decryptTextButton
            // 
            decryptTextButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            decryptTextButton.ForeColor = SystemColors.ActiveCaptionText;
            decryptTextButton.Location = new Point(471, 112);
            decryptTextButton.Name = "decryptTextButton";
            decryptTextButton.Size = new Size(136, 44);
            decryptTextButton.TabIndex = 2;
            decryptTextButton.Text = "Decrypt Text";
            decryptTextButton.UseVisualStyleBackColor = true;
            decryptTextButton.Click += DecryptTextClicked;
            // 
            // encryptFileButton
            // 
            encryptFileButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            encryptFileButton.ForeColor = SystemColors.ActiveCaptionText;
            encryptFileButton.Location = new Point(189, 112);
            encryptFileButton.Name = "encryptFileButton";
            encryptFileButton.Size = new Size(136, 44);
            encryptFileButton.TabIndex = 3;
            encryptFileButton.Text = "Encrypt File";
            encryptFileButton.UseVisualStyleBackColor = true;
            // 
            // decryptFileButton
            // 
            decryptFileButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            decryptFileButton.ForeColor = SystemColors.ActiveCaptionText;
            decryptFileButton.Location = new Point(613, 112);
            decryptFileButton.Name = "decryptFileButton";
            decryptFileButton.Size = new Size(136, 44);
            decryptFileButton.TabIndex = 4;
            decryptFileButton.Text = "Decrypt File";
            decryptFileButton.UseVisualStyleBackColor = true;
            // 
            // extraInfoLabel
            // 
            extraInfoLabel.AutoSize = true;
            extraInfoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            extraInfoLabel.Location = new Point(115, 190);
            extraInfoLabel.Name = "extraInfoLabel";
            extraInfoLabel.Size = new Size(586, 21);
            extraInfoLabel.TabIndex = 5;
            extraInfoLabel.Text = "You can either upload a text file or enter a message through the application directly.";
            extraInfoLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // CaesarCipherForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(802, 242);
            Controls.Add(extraInfoLabel);
            Controls.Add(decryptFileButton);
            Controls.Add(encryptFileButton);
            Controls.Add(decryptTextButton);
            Controls.Add(welcomeLabel);
            Controls.Add(encryptTextButton);
            ForeColor = SystemColors.ControlLight;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CaesarCipherForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Caesar Cipher";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button encryptTextButton;
        private Label welcomeLabel;
        private Button decryptTextButton;
        private Button encryptFileButton;
        private Button decryptFileButton;
        private Label extraInfoLabel;
    }
}
