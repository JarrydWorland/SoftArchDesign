
namespace CozyKangarooSoftwareProject
{
    partial class StaffLogin
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
			this.usernameLabel = new System.Windows.Forms.Label();
			this.usernameInput = new System.Windows.Forms.TextBox();
			this.passwordInput = new System.Windows.Forms.TextBox();
			this.passwordLabel = new System.Windows.Forms.Label();
			this.loginButton = new System.Windows.Forms.Button();
			this.backButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// usernameLabel
			// 
			this.usernameLabel.AutoSize = true;
			this.usernameLabel.Location = new System.Drawing.Point(12, 9);
			this.usernameLabel.Name = "usernameLabel";
			this.usernameLabel.Size = new System.Drawing.Size(61, 13);
			this.usernameLabel.TabIndex = 0;
			this.usernameLabel.Text = "Username: ";
			this.usernameLabel.Click += new System.EventHandler(this.label1_Click);
			// 
			// usernameInput
			// 
			this.usernameInput.Location = new System.Drawing.Point(79, 6);
			this.usernameInput.Name = "usernameInput";
			this.usernameInput.Size = new System.Drawing.Size(100, 20);
			this.usernameInput.TabIndex = 1;
			// 
			// passwordInput
			// 
			this.passwordInput.Location = new System.Drawing.Point(79, 33);
			this.passwordInput.Name = "passwordInput";
			this.passwordInput.Size = new System.Drawing.Size(100, 20);
			this.passwordInput.TabIndex = 2;
			// 
			// passwordLabel
			// 
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.Location = new System.Drawing.Point(14, 36);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(59, 13);
			this.passwordLabel.TabIndex = 3;
			this.passwordLabel.Text = "Password: ";
			// 
			// loginButton
			// 
			this.loginButton.Location = new System.Drawing.Point(12, 59);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(75, 23);
			this.loginButton.TabIndex = 4;
			this.loginButton.Text = "Login";
			this.loginButton.UseVisualStyleBackColor = true;
			// 
			// backButton
			// 
			this.backButton.Location = new System.Drawing.Point(12, 88);
			this.backButton.Name = "backButton";
			this.backButton.Size = new System.Drawing.Size(75, 23);
			this.backButton.TabIndex = 5;
			this.backButton.Text = "<< Back";
			this.backButton.UseVisualStyleBackColor = true;
			// 
			// StaffLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.backButton);
			this.Controls.Add(this.loginButton);
			this.Controls.Add(this.passwordLabel);
			this.Controls.Add(this.passwordInput);
			this.Controls.Add(this.usernameInput);
			this.Controls.Add(this.usernameLabel);
			this.Name = "StaffLogin";
			this.Text = "Staff Login";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Label usernameLabel;
		private System.Windows.Forms.TextBox usernameInput;
		private System.Windows.Forms.TextBox passwordInput;
		private System.Windows.Forms.Label passwordLabel;
		private System.Windows.Forms.Button loginButton;
		private System.Windows.Forms.Button backButton;
	}
}