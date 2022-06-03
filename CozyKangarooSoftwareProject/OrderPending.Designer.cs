
namespace CozyKangarooSoftwareProject
{
    partial class OrderPending
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
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.message1 = new System.Windows.Forms.Label();
			this.message2 = new System.Windows.Forms.Label();
			this.closeButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(15, 38);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(281, 197);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "1 X Pizza\n$10.00\n\n1 X Fries\n$5.00\n\nTotal: $15.00";
			// 
			// message1
			// 
			this.message1.AutoSize = true;
			this.message1.Location = new System.Drawing.Point(12, 9);
			this.message1.Name = "message1";
			this.message1.Size = new System.Drawing.Size(351, 13);
			this.message1.TabIndex = 1;
			this.message1.Text = "Your order has been processed. Thank you for choosing Cozy Kangaroo!";
			// 
			// message2
			// 
			this.message2.AutoSize = true;
			this.message2.Location = new System.Drawing.Point(12, 22);
			this.message2.Name = "message2";
			this.message2.Size = new System.Drawing.Size(164, 13);
			this.message2.TabIndex = 2;
			this.message2.Text = "Here are the details of your order:";
			// 
			// closeButton
			// 
			this.closeButton.Location = new System.Drawing.Point(15, 242);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(75, 23);
			this.closeButton.TabIndex = 3;
			this.closeButton.Text = "Close";
			this.closeButton.UseVisualStyleBackColor = true;
			// 
			// OrderPending
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.message2);
			this.Controls.Add(this.message1);
			this.Controls.Add(this.richTextBox1);
			this.Name = "OrderPending";
			this.Text = "Receipt";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Label message1;
		private System.Windows.Forms.Label message2;
		private System.Windows.Forms.Button closeButton;
	}
}