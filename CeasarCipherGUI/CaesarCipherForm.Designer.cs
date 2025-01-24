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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaesarCipherForm));
            encryptTextButton = new Button();
            welcomeLabel = new Label();
            decryptTextButton = new Button();
            SuspendLayout();
            // 
            // encryptTextButton
            // 
            encryptTextButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            encryptTextButton.ForeColor = SystemColors.ActiveCaptionText;
            encryptTextButton.Location = new Point(12, 134);
            encryptTextButton.Name = "encryptTextButton";
            encryptTextButton.Size = new Size(136, 44);
            encryptTextButton.TabIndex = 0;
            encryptTextButton.Text = "Encrypt Text";
            encryptTextButton.UseVisualStyleBackColor = true;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            welcomeLabel.Location = new Point(12, 9);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(769, 80);
            welcomeLabel.TabIndex = 1;
            welcomeLabel.Text = resources.GetString("welcomeLabel.Text");
            welcomeLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // decryptTextButton
            // 
            decryptTextButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            decryptTextButton.ForeColor = SystemColors.ActiveCaptionText;
            decryptTextButton.Location = new Point(645, 134);
            decryptTextButton.Name = "decryptTextButton";
            decryptTextButton.Size = new Size(136, 44);
            decryptTextButton.TabIndex = 2;
            decryptTextButton.Text = "Decrypt Text";
            decryptTextButton.UseVisualStyleBackColor = true;
            // 
            // CaesarCipherForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(802, 304);
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
    }
}
