namespace CarRental
{
    partial class FormLogin
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
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.submitLoginButton = new System.Windows.Forms.Button();
            this.showPasswordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(116, 99);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(279, 26);
            this.usernameTextBox.TabIndex = 0;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(234, 76);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(43, 20);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "User";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(116, 193);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(279, 26);
            this.passwordTextBox.TabIndex = 2;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(216, 170);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(78, 20);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password";
            // 
            // submitLoginButton
            // 
            this.submitLoginButton.Location = new System.Drawing.Point(200, 329);
            this.submitLoginButton.Name = "submitLoginButton";
            this.submitLoginButton.Size = new System.Drawing.Size(114, 55);
            this.submitLoginButton.TabIndex = 4;
            this.submitLoginButton.Text = "Submit";
            this.submitLoginButton.UseVisualStyleBackColor = true;
            this.submitLoginButton.Click += new System.EventHandler(this.submitLoginButton_Click);
            // 
            // showPasswordLabel
            // 
            this.showPasswordLabel.AutoSize = true;
            this.showPasswordLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPasswordLabel.Location = new System.Drawing.Point(196, 238);
            this.showPasswordLabel.Name = "showPasswordLabel";
            this.showPasswordLabel.Size = new System.Drawing.Size(118, 20);
            this.showPasswordLabel.TabIndex = 5;
            this.showPasswordLabel.Text = "show password";
            this.showPasswordLabel.Click += new System.EventHandler(this.showPasswordLabel_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 396);
            this.Controls.Add(this.showPasswordLabel);
            this.Controls.Add(this.submitLoginButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLogin_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button submitLoginButton;
        private System.Windows.Forms.Label showPasswordLabel;
    }
}