
namespace CozyKangarooSoftwareProject
{
    partial class PaymentForm
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
			this.mainMessage = new System.Windows.Forms.Label();
			this.cardNumberInput = new System.Windows.Forms.TextBox();
			this.cardNumberLabel = new System.Windows.Forms.Label();
			this.expiryDateLabel = new System.Windows.Forms.Label();
			this.cardExpiryMonth = new System.Windows.Forms.TextBox();
			this.cardExpirySlash = new System.Windows.Forms.Label();
			this.cardExpiryYear = new System.Windows.Forms.TextBox();
			this.cvvInput = new System.Windows.Forms.TextBox();
			this.cvvLabel = new System.Windows.Forms.Label();
			this.submitButton = new System.Windows.Forms.Button();
			this.backButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// mainMessage
			// 
			this.mainMessage.AutoSize = true;
			this.mainMessage.Location = new System.Drawing.Point(13, 13);
			this.mainMessage.Name = "mainMessage";
			this.mainMessage.Size = new System.Drawing.Size(260, 13);
			this.mainMessage.TabIndex = 0;
			this.mainMessage.Text = "Please enter your bank card info to pay for your order:";
			// 
			// cardNumberInput
			// 
			this.cardNumberInput.Location = new System.Drawing.Point(154, 29);
			this.cardNumberInput.MaxLength = 16;
			this.cardNumberInput.Name = "cardNumberInput";
			this.cardNumberInput.Size = new System.Drawing.Size(100, 20);
			this.cardNumberInput.TabIndex = 1;
			// 
			// cardNumberLabel
			// 
			this.cardNumberLabel.AutoSize = true;
			this.cardNumberLabel.Location = new System.Drawing.Point(13, 32);
			this.cardNumberLabel.Name = "cardNumberLabel";
			this.cardNumberLabel.Size = new System.Drawing.Size(72, 13);
			this.cardNumberLabel.TabIndex = 2;
			this.cardNumberLabel.Text = "Card Number:";
			// 
			// expiryDateLabel
			// 
			this.expiryDateLabel.AutoSize = true;
			this.expiryDateLabel.Location = new System.Drawing.Point(13, 58);
			this.expiryDateLabel.Name = "expiryDateLabel";
			this.expiryDateLabel.Size = new System.Drawing.Size(135, 13);
			this.expiryDateLabel.TabIndex = 3;
			this.expiryDateLabel.Text = "Card Expiry Date (MM/YY):";
			// 
			// cardExpiryMonth
			// 
			this.cardExpiryMonth.Location = new System.Drawing.Point(154, 55);
			this.cardExpiryMonth.MaxLength = 2;
			this.cardExpiryMonth.Name = "cardExpiryMonth";
			this.cardExpiryMonth.Size = new System.Drawing.Size(20, 20);
			this.cardExpiryMonth.TabIndex = 4;
			this.cardExpiryMonth.TextChanged += new System.EventHandler(this.cardExpiryMonth_TextChanged);
			// 
			// cardExpirySlash
			// 
			this.cardExpirySlash.AutoSize = true;
			this.cardExpirySlash.Location = new System.Drawing.Point(180, 58);
			this.cardExpirySlash.Name = "cardExpirySlash";
			this.cardExpirySlash.Size = new System.Drawing.Size(12, 13);
			this.cardExpirySlash.TabIndex = 5;
			this.cardExpirySlash.Text = "/";
			this.cardExpirySlash.Click += new System.EventHandler(this.cardExpirySlash_Click);
			// 
			// cardExpiryYear
			// 
			this.cardExpiryYear.Location = new System.Drawing.Point(198, 55);
			this.cardExpiryYear.MaxLength = 2;
			this.cardExpiryYear.Name = "cardExpiryYear";
			this.cardExpiryYear.Size = new System.Drawing.Size(20, 20);
			this.cardExpiryYear.TabIndex = 6;
			this.cardExpiryYear.TextChanged += new System.EventHandler(this.cardExpiryYear_TextChanged);
			// 
			// cvvInput
			// 
			this.cvvInput.Location = new System.Drawing.Point(154, 81);
			this.cvvInput.MaxLength = 3;
			this.cvvInput.Name = "cvvInput";
			this.cvvInput.Size = new System.Drawing.Size(30, 20);
			this.cvvInput.TabIndex = 7;
			// 
			// cvvLabel
			// 
			this.cvvLabel.AutoSize = true;
			this.cvvLabel.Location = new System.Drawing.Point(13, 84);
			this.cvvLabel.Name = "cvvLabel";
			this.cvvLabel.Size = new System.Drawing.Size(31, 13);
			this.cvvLabel.TabIndex = 8;
			this.cvvLabel.Text = "CVV:";
			// 
			// submitButton
			// 
			this.submitButton.Location = new System.Drawing.Point(16, 100);
			this.submitButton.Name = "submitButton";
			this.submitButton.Size = new System.Drawing.Size(75, 23);
			this.submitButton.TabIndex = 9;
			this.submitButton.Text = "Submit";
			this.submitButton.UseVisualStyleBackColor = true;
			// 
			// backButton
			// 
			this.backButton.Location = new System.Drawing.Point(16, 129);
			this.backButton.Name = "backButton";
			this.backButton.Size = new System.Drawing.Size(75, 23);
			this.backButton.TabIndex = 10;
			this.backButton.Text = "<< Back";
			this.backButton.UseVisualStyleBackColor = true;
			// 
			// PaymentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.backButton);
			this.Controls.Add(this.submitButton);
			this.Controls.Add(this.cvvLabel);
			this.Controls.Add(this.cvvInput);
			this.Controls.Add(this.cardExpiryYear);
			this.Controls.Add(this.cardExpirySlash);
			this.Controls.Add(this.cardExpiryMonth);
			this.Controls.Add(this.expiryDateLabel);
			this.Controls.Add(this.cardNumberLabel);
			this.Controls.Add(this.cardNumberInput);
			this.Controls.Add(this.mainMessage);
			this.Name = "PaymentForm";
			this.Text = "Payment";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Label mainMessage;
		private System.Windows.Forms.TextBox cardNumberInput;
		private System.Windows.Forms.Label cardNumberLabel;
		private System.Windows.Forms.Label expiryDateLabel;
		private System.Windows.Forms.TextBox cardExpiryMonth;
		private System.Windows.Forms.Label cardExpirySlash;
		private System.Windows.Forms.TextBox cardExpiryYear;
		private System.Windows.Forms.TextBox cvvInput;
		private System.Windows.Forms.Label cvvLabel;
		private System.Windows.Forms.Button submitButton;
		private System.Windows.Forms.Button backButton;
	}
}