
namespace CozyKangarooSoftwareProject
{
    partial class OrderForm
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
			this.item0Checkbox = new System.Windows.Forms.CheckBox();
			this.item1Checkbox = new System.Windows.Forms.CheckBox();
			this.item2Checkbox = new System.Windows.Forms.CheckBox();
			this.item0Amount = new System.Windows.Forms.NumericUpDown();
			this.item1Amount = new System.Windows.Forms.NumericUpDown();
			this.item2Amount = new System.Windows.Forms.NumericUpDown();
			this.item0Description = new System.Windows.Forms.Label();
			this.item0VeganState = new System.Windows.Forms.Label();
			this.item0Price = new System.Windows.Forms.Label();
			this.item1Description = new System.Windows.Forms.Label();
			this.item1VeganState = new System.Windows.Forms.Label();
			this.item1Price = new System.Windows.Forms.Label();
			this.item2Description = new System.Windows.Forms.Label();
			this.item2VeganState = new System.Windows.Forms.Label();
			this.item2Price = new System.Windows.Forms.Label();
			this.backButton = new System.Windows.Forms.Button();
			this.submitButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.item0Amount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.item1Amount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.item2Amount)).BeginInit();
			this.SuspendLayout();
			// 
			// item0Checkbox
			// 
			this.item0Checkbox.AutoSize = true;
			this.item0Checkbox.Location = new System.Drawing.Point(12, 12);
			this.item0Checkbox.Name = "item0Checkbox";
			this.item0Checkbox.Size = new System.Drawing.Size(51, 17);
			this.item0Checkbox.TabIndex = 0;
			this.item0Checkbox.Text = "Pizza";
			this.item0Checkbox.UseVisualStyleBackColor = true;
			this.item0Checkbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// item1Checkbox
			// 
			this.item1Checkbox.AutoSize = true;
			this.item1Checkbox.Checked = true;
			this.item1Checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.item1Checkbox.Location = new System.Drawing.Point(12, 75);
			this.item1Checkbox.Name = "item1Checkbox";
			this.item1Checkbox.Size = new System.Drawing.Size(48, 17);
			this.item1Checkbox.TabIndex = 1;
			this.item1Checkbox.Text = "Fries";
			this.item1Checkbox.UseVisualStyleBackColor = true;
			// 
			// item2Checkbox
			// 
			this.item2Checkbox.AutoSize = true;
			this.item2Checkbox.Location = new System.Drawing.Point(12, 138);
			this.item2Checkbox.Name = "item2Checkbox";
			this.item2Checkbox.Size = new System.Drawing.Size(71, 17);
			this.item2Checkbox.TabIndex = 2;
			this.item2Checkbox.Text = "Spaghetti";
			this.item2Checkbox.UseVisualStyleBackColor = true;
			// 
			// item0Amount
			// 
			this.item0Amount.Location = new System.Drawing.Point(150, 11);
			this.item0Amount.Name = "item0Amount";
			this.item0Amount.ReadOnly = true;
			this.item0Amount.Size = new System.Drawing.Size(120, 20);
			this.item0Amount.TabIndex = 3;
			// 
			// item1Amount
			// 
			this.item1Amount.Location = new System.Drawing.Point(150, 74);
			this.item1Amount.Name = "item1Amount";
			this.item1Amount.Size = new System.Drawing.Size(120, 20);
			this.item1Amount.TabIndex = 4;
			// 
			// item2Amount
			// 
			this.item2Amount.Location = new System.Drawing.Point(150, 137);
			this.item2Amount.Name = "item2Amount";
			this.item2Amount.ReadOnly = true;
			this.item2Amount.Size = new System.Drawing.Size(120, 20);
			this.item2Amount.TabIndex = 5;
			// 
			// item0Description
			// 
			this.item0Description.AutoSize = true;
			this.item0Description.Location = new System.Drawing.Point(12, 32);
			this.item0Description.Name = "item0Description";
			this.item0Description.Size = new System.Drawing.Size(159, 13);
			this.item0Description.TabIndex = 6;
			this.item0Description.Text = "A pizza with pepperoni toppings.";
			// 
			// item0VeganState
			// 
			this.item0VeganState.AutoSize = true;
			this.item0VeganState.Location = new System.Drawing.Point(12, 45);
			this.item0VeganState.Name = "item0VeganState";
			this.item0VeganState.Size = new System.Drawing.Size(61, 13);
			this.item0VeganState.TabIndex = 7;
			this.item0VeganState.Text = "Non-Vegan";
			// 
			// item0Price
			// 
			this.item0Price.AutoSize = true;
			this.item0Price.Location = new System.Drawing.Point(12, 58);
			this.item0Price.Name = "item0Price";
			this.item0Price.Size = new System.Drawing.Size(40, 13);
			this.item0Price.TabIndex = 8;
			this.item0Price.Text = "$10.00";
			// 
			// item1Description
			// 
			this.item1Description.AutoSize = true;
			this.item1Description.Location = new System.Drawing.Point(12, 95);
			this.item1Description.Name = "item1Description";
			this.item1Description.Size = new System.Drawing.Size(84, 13);
			this.item1Description.TabIndex = 9;
			this.item1Description.Text = "Beer-batter fries.";
			// 
			// item1VeganState
			// 
			this.item1VeganState.AutoSize = true;
			this.item1VeganState.Location = new System.Drawing.Point(12, 108);
			this.item1VeganState.Name = "item1VeganState";
			this.item1VeganState.Size = new System.Drawing.Size(38, 13);
			this.item1VeganState.TabIndex = 10;
			this.item1VeganState.Text = "Vegan";
			// 
			// item1Price
			// 
			this.item1Price.AutoSize = true;
			this.item1Price.Location = new System.Drawing.Point(12, 121);
			this.item1Price.Name = "item1Price";
			this.item1Price.Size = new System.Drawing.Size(34, 13);
			this.item1Price.TabIndex = 11;
			this.item1Price.Text = "$5.00";
			// 
			// item2Description
			// 
			this.item2Description.AutoSize = true;
			this.item2Description.Location = new System.Drawing.Point(12, 158);
			this.item2Description.Name = "item2Description";
			this.item2Description.Size = new System.Drawing.Size(265, 13);
			this.item2Description.TabIndex = 12;
			this.item2Description.Text = "Spaghetti and meatballs with shredded mature cheese.";
			// 
			// item2VeganState
			// 
			this.item2VeganState.AutoSize = true;
			this.item2VeganState.Location = new System.Drawing.Point(12, 171);
			this.item2VeganState.Name = "item2VeganState";
			this.item2VeganState.Size = new System.Drawing.Size(61, 13);
			this.item2VeganState.TabIndex = 13;
			this.item2VeganState.Text = "Non-Vegan";
			// 
			// item2Price
			// 
			this.item2Price.AutoSize = true;
			this.item2Price.Location = new System.Drawing.Point(12, 184);
			this.item2Price.Name = "item2Price";
			this.item2Price.Size = new System.Drawing.Size(40, 13);
			this.item2Price.TabIndex = 14;
			this.item2Price.Text = "$15.00";
			// 
			// backButton
			// 
			this.backButton.Location = new System.Drawing.Point(12, 229);
			this.backButton.Name = "backButton";
			this.backButton.Size = new System.Drawing.Size(75, 23);
			this.backButton.TabIndex = 15;
			this.backButton.Text = "<< Back";
			this.backButton.UseVisualStyleBackColor = true;
			// 
			// submitButton
			// 
			this.submitButton.Location = new System.Drawing.Point(12, 200);
			this.submitButton.Name = "submitButton";
			this.submitButton.Size = new System.Drawing.Size(125, 23);
			this.submitButton.TabIndex = 16;
			this.submitButton.Text = "Proceed to Payment";
			this.submitButton.UseVisualStyleBackColor = true;
			// 
			// OrderForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.submitButton);
			this.Controls.Add(this.backButton);
			this.Controls.Add(this.item2Price);
			this.Controls.Add(this.item2VeganState);
			this.Controls.Add(this.item2Description);
			this.Controls.Add(this.item1Price);
			this.Controls.Add(this.item1VeganState);
			this.Controls.Add(this.item1Description);
			this.Controls.Add(this.item0Price);
			this.Controls.Add(this.item0VeganState);
			this.Controls.Add(this.item0Description);
			this.Controls.Add(this.item2Amount);
			this.Controls.Add(this.item1Amount);
			this.Controls.Add(this.item0Amount);
			this.Controls.Add(this.item2Checkbox);
			this.Controls.Add(this.item1Checkbox);
			this.Controls.Add(this.item0Checkbox);
			this.Name = "OrderForm";
			this.Text = "Make an Order";
			((System.ComponentModel.ISupportInitialize)(this.item0Amount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.item1Amount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.item2Amount)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.CheckBox item0Checkbox;
		private System.Windows.Forms.CheckBox item1Checkbox;
		private System.Windows.Forms.CheckBox item2Checkbox;
		private System.Windows.Forms.NumericUpDown item0Amount;
		private System.Windows.Forms.NumericUpDown item1Amount;
		private System.Windows.Forms.NumericUpDown item2Amount;
		private System.Windows.Forms.Label item0Description;
		private System.Windows.Forms.Label item0VeganState;
		private System.Windows.Forms.Label item0Price;
		private System.Windows.Forms.Label item1Description;
		private System.Windows.Forms.Label item1VeganState;
		private System.Windows.Forms.Label item1Price;
		private System.Windows.Forms.Label item2Description;
		private System.Windows.Forms.Label item2VeganState;
		private System.Windows.Forms.Label item2Price;
		private System.Windows.Forms.Button backButton;
		private System.Windows.Forms.Button submitButton;
	}
}