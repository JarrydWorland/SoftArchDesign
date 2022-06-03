
namespace CozyKangarooSoftwareProject
{
    partial class Reservations
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
			this.tableNumberLabel = new System.Windows.Forms.Label();
			this.tableNumberInput = new System.Windows.Forms.TextBox();
			this.submitButton = new System.Windows.Forms.Button();
			this.backButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tableNumberLabel
			// 
			this.tableNumberLabel.AutoSize = true;
			this.tableNumberLabel.Location = new System.Drawing.Point(12, 15);
			this.tableNumberLabel.Name = "tableNumberLabel";
			this.tableNumberLabel.Size = new System.Drawing.Size(149, 13);
			this.tableNumberLabel.TabIndex = 0;
			this.tableNumberLabel.Text = "Enter table number to reserve:";
			// 
			// tableNumberInput
			// 
			this.tableNumberInput.Location = new System.Drawing.Point(167, 12);
			this.tableNumberInput.MaxLength = 2;
			this.tableNumberInput.Name = "tableNumberInput";
			this.tableNumberInput.Size = new System.Drawing.Size(20, 20);
			this.tableNumberInput.TabIndex = 1;
			// 
			// submitButton
			// 
			this.submitButton.Location = new System.Drawing.Point(15, 31);
			this.submitButton.Name = "submitButton";
			this.submitButton.Size = new System.Drawing.Size(75, 23);
			this.submitButton.TabIndex = 2;
			this.submitButton.Text = "Submit";
			this.submitButton.UseVisualStyleBackColor = true;
			// 
			// backButton
			// 
			this.backButton.Location = new System.Drawing.Point(15, 60);
			this.backButton.Name = "backButton";
			this.backButton.Size = new System.Drawing.Size(75, 23);
			this.backButton.TabIndex = 3;
			this.backButton.Text = "<< Back";
			this.backButton.UseVisualStyleBackColor = true;
			// 
			// Reservations
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.backButton);
			this.Controls.Add(this.submitButton);
			this.Controls.Add(this.tableNumberInput);
			this.Controls.Add(this.tableNumberLabel);
			this.Name = "Reservations";
			this.Text = "Reserve a Table";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Label tableNumberLabel;
		private System.Windows.Forms.TextBox tableNumberInput;
		private System.Windows.Forms.Button submitButton;
		private System.Windows.Forms.Button backButton;
	}
}