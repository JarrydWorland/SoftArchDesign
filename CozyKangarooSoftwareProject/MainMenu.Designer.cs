
namespace CozyKangarooSoftwareProject
{
    partial class MainMenu
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
			this.label1 = new System.Windows.Forms.Label();
			this.orderButton = new System.Windows.Forms.Button();
			this.reservationButton = new System.Windows.Forms.Button();
			this.staffButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(274, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Welcome to Cozy Kangaroo! What would you like to do?";
			// 
			// orderButton
			// 
			this.orderButton.Location = new System.Drawing.Point(16, 30);
			this.orderButton.Name = "orderButton";
			this.orderButton.Size = new System.Drawing.Size(75, 23);
			this.orderButton.TabIndex = 1;
			this.orderButton.Text = "Order";
			this.orderButton.UseVisualStyleBackColor = true;
			this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
			// 
			// reservationButton
			// 
			this.reservationButton.Location = new System.Drawing.Point(98, 29);
			this.reservationButton.Name = "reservationButton";
			this.reservationButton.Size = new System.Drawing.Size(125, 23);
			this.reservationButton.TabIndex = 2;
			this.reservationButton.Text = "Make Reservation";
			this.reservationButton.UseVisualStyleBackColor = true;
			this.reservationButton.Click += new System.EventHandler(this.reservationButton_Click);
			// 
			// staffButton
			// 
			this.staffButton.Location = new System.Drawing.Point(230, 28);
			this.staffButton.Name = "staffButton";
			this.staffButton.Size = new System.Drawing.Size(100, 23);
			this.staffButton.TabIndex = 3;
			this.staffButton.Text = "Login as Staff";
			this.staffButton.UseVisualStyleBackColor = true;
			this.staffButton.Click += new System.EventHandler(this.staffButton_Click);
			// 
			// MainMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1030, 594);
			this.Controls.Add(this.staffButton);
			this.Controls.Add(this.reservationButton);
			this.Controls.Add(this.orderButton);
			this.Controls.Add(this.label1);
			this.Name = "MainMenu";
			this.Text = "Cozy Kangaroo";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button orderButton;
		private System.Windows.Forms.Button reservationButton;
		private System.Windows.Forms.Button staffButton;
	}
}

