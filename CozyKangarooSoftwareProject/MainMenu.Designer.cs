
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
            this.FoodMenu = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.currentOrders = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FoodMenu
            // 
            this.FoodMenu.Location = new System.Drawing.Point(12, 12);
            this.FoodMenu.Name = "FoodMenu";
            this.FoodMenu.Size = new System.Drawing.Size(128, 55);
            this.FoodMenu.TabIndex = 0;
            this.FoodMenu.Text = "Show menu";
            this.FoodMenu.UseVisualStyleBackColor = true;
            this.FoodMenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(170, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 55);
            this.button2.TabIndex = 2;
            this.button2.Text = "Make an order";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1134, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 55);
            this.button3.TabIndex = 3;
            this.button3.Text = "Kitchen Login";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1134, 79);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 55);
            this.button4.TabIndex = 4;
            this.button4.Text = "Wait Login";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(323, 14);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(113, 53);
            this.button5.TabIndex = 5;
            this.button5.Text = "Book table";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // currentOrders
            // 
            this.currentOrders.FormattingEnabled = true;
            this.currentOrders.Location = new System.Drawing.Point(487, 240);
            this.currentOrders.Name = "currentOrders";
            this.currentOrders.Size = new System.Drawing.Size(120, 95);
            this.currentOrders.TabIndex = 6;
            this.currentOrders.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(503, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MainMenu
            // 
            this.ClientSize = new System.Drawing.Size(1256, 591);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.currentOrders);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.FoodMenu);
            this.Name = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FoodMenu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListBox currentOrders;
        private System.Windows.Forms.Button button1;
    }
}

