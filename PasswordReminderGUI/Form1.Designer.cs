namespace PasswordReminderGUI
{
    partial class passwordForm
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
            this.remindText = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // remindText
            // 
            this.remindText.AutoSize = true;
            this.remindText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.remindText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.remindText.Location = new System.Drawing.Point(12, 9);
            this.remindText.Name = "remindText";
            this.remindText.Size = new System.Drawing.Size(534, 42);
            this.remindText.TabIndex = 0;
            this.remindText.Text = "Hallo {username} ihr Passwort läuft in {days} Tagen ab\r\nSie können das Passwort m" +
    "it der Tastenkombination STRG ALT ENTF ändern\r\n";
            this.remindText.Click += new System.EventHandler(this.remindText_Click);
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.LimeGreen;
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.changeButton.ForeColor = System.Drawing.Color.Snow;
            this.changeButton.Location = new System.Drawing.Point(12, 63);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(534, 42);
            this.changeButton.TabIndex = 1;
            this.changeButton.Text = "Okay";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.abortButton_Click);
            // 
            // passwordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(554, 112);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.remindText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "passwordForm";
            this.Text = "Passwort Errinerung";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
            this.CenterToScreen();
        }

        #endregion

        private Label remindText;
        private Button changeButton;
    }
}