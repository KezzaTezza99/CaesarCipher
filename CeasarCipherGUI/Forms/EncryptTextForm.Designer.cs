namespace CeasarCipherGUI
{
    partial class EncryptTextForm
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
            etfPlainTextInput = new RichTextBox();
            etfEncryptedTextOutput = new RichTextBox();
            etfLabel = new Label();
            etfCipherKey = new NumericUpDown();
            etfEncryptButton = new Button();
            ((System.ComponentModel.ISupportInitialize)etfCipherKey).BeginInit();
            SuspendLayout();
            // 
            // etfPlainTextInput
            // 
            etfPlainTextInput.Location = new Point(12, 50);
            etfPlainTextInput.Name = "etfPlainTextInput";
            etfPlainTextInput.Size = new Size(776, 84);
            etfPlainTextInput.TabIndex = 1;
            etfPlainTextInput.Text = "";
            // 
            // etfEncryptedTextOutput
            // 
            etfEncryptedTextOutput.Location = new Point(12, 231);
            etfEncryptedTextOutput.Name = "etfEncryptedTextOutput";
            etfEncryptedTextOutput.Size = new Size(776, 173);
            etfEncryptedTextOutput.TabIndex = 2;
            etfEncryptedTextOutput.Text = "";
            // 
            // etfLabel
            // 
            etfLabel.AutoSize = true;
            etfLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            etfLabel.ForeColor = Color.White;
            etfLabel.Location = new Point(77, 9);
            etfLabel.Name = "etfLabel";
            etfLabel.Size = new Size(626, 17);
            etfLabel.TabIndex = 4;
            etfLabel.Text = "Enter your plain text below along with a key to decider how to cipher the text then click the button!";
            // 
            // etfCipherKey
            // 
            etfCipherKey.Location = new Point(668, 149);
            etfCipherKey.Name = "etfCipherKey";
            etfCipherKey.Size = new Size(120, 23);
            etfCipherKey.TabIndex = 5;
            // 
            // etfEncryptButton
            // 
            etfEncryptButton.Location = new Point(668, 178);
            etfEncryptButton.Name = "etfEncryptButton";
            etfEncryptButton.Size = new Size(120, 47);
            etfEncryptButton.TabIndex = 6;
            etfEncryptButton.Text = "Encrypt!";
            etfEncryptButton.UseVisualStyleBackColor = true;
            etfEncryptButton.Click += EncryptText;
            // 
            // EncryptTextForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(800, 450);
            Controls.Add(etfEncryptButton);
            Controls.Add(etfCipherKey);
            Controls.Add(etfLabel);
            Controls.Add(etfEncryptedTextOutput);
            Controls.Add(etfPlainTextInput);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EncryptTextForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Encrypt Text";
            ((System.ComponentModel.ISupportInitialize)etfCipherKey).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox etfPlainTextInput;
        private RichTextBox etfEncryptedTextOutput;
        private Label etfLabel;
        private NumericUpDown etfCipherKey;
        private Button etfEncryptButton;
    }
}