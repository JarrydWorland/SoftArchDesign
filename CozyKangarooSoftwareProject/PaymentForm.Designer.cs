
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
            this.NameBox = new System.Windows.Forms.TextBox();
            this.CardNumberBox = new System.Windows.Forms.TextBox();
            this.MonthExpiryBox = new System.Windows.Forms.TextBox();
            this.YearExpiryBox = new System.Windows.Forms.TextBox();
            this.CvvBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(402, 121);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 20);
            this.NameBox.TabIndex = 0;
            this.NameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CardNumberBox
            // 
            this.CardNumberBox.Location = new System.Drawing.Point(402, 173);
            this.CardNumberBox.Name = "CardNumberBox";
            this.CardNumberBox.Size = new System.Drawing.Size(100, 20);
            this.CardNumberBox.TabIndex = 1;
            // 
            // MonthExpiryBox
            // 
            this.MonthExpiryBox.Location = new System.Drawing.Point(402, 229);
            this.MonthExpiryBox.Name = "MonthExpiryBox";
            this.MonthExpiryBox.Size = new System.Drawing.Size(100, 20);
            this.MonthExpiryBox.TabIndex = 2;
            // 
            // YearExpiryBox
            // 
            this.YearExpiryBox.Location = new System.Drawing.Point(402, 283);
            this.YearExpiryBox.Name = "YearExpiryBox";
            this.YearExpiryBox.Size = new System.Drawing.Size(100, 20);
            this.YearExpiryBox.TabIndex = 3;
            // 
            // CvvBox
            // 
            this.CvvBox.Location = new System.Drawing.Point(402, 333);
            this.CvvBox.Name = "CvvBox";
            this.CvvBox.Size = new System.Drawing.Size(100, 20);
            this.CvvBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(365, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Pay";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(464, 369);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Back to menu";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CvvBox);
            this.Controls.Add(this.YearExpiryBox);
            this.Controls.Add(this.MonthExpiryBox);
            this.Controls.Add(this.CardNumberBox);
            this.Controls.Add(this.NameBox);
            this.Name = "PaymentForm";
            this.Text = "PaymentForm";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox CardNumberBox;
        private System.Windows.Forms.TextBox MonthExpiryBox;
        private System.Windows.Forms.TextBox YearExpiryBox;
        private System.Windows.Forms.TextBox CvvBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}