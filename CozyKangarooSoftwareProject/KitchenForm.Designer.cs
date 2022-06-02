namespace CozyKangarooSoftwareProject
{
    partial class KitchenForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.deliveredBox = new System.Windows.Forms.TextBox();
            this.timeBox = new System.Windows.Forms.TextBox();
            this.FinishedBox = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(939, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Finish order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(770, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Delay";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(861, 127);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Speed up";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(683, 102);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(327, 20);
            this.inputBox.TabIndex = 3;
            this.inputBox.TextChanged += new System.EventHandler(this.inputBox_TextChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(683, 127);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Check";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(710, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(801, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Time";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(869, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Delivered";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(955, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Finished";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(683, 189);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(75, 20);
            this.idBox.TabIndex = 9;
            this.idBox.TextChanged += new System.EventHandler(this.idBox_TextChanged);
            // 
            // deliveredBox
            // 
            this.deliveredBox.Location = new System.Drawing.Point(861, 189);
            this.deliveredBox.Name = "deliveredBox";
            this.deliveredBox.Size = new System.Drawing.Size(72, 20);
            this.deliveredBox.TabIndex = 10;
            this.deliveredBox.TextChanged += new System.EventHandler(this.deliveredBox_TextChanged);
            // 
            // timeBox
            // 
            this.timeBox.Location = new System.Drawing.Point(770, 189);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(85, 20);
            this.timeBox.TabIndex = 11;
            this.timeBox.TextChanged += new System.EventHandler(this.timeBox_TextChanged);
            // 
            // FinishedBox
            // 
            this.FinishedBox.Location = new System.Drawing.Point(939, 189);
            this.FinishedBox.Name = "FinishedBox";
            this.FinishedBox.Size = new System.Drawing.Size(71, 20);
            this.FinishedBox.TabIndex = 12;
            this.FinishedBox.TextChanged += new System.EventHandler(this.FinishedBox_TextChanged);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(779, 249);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(162, 66);
            this.Back.TabIndex = 13;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // KitchenForm
            // 
            this.ClientSize = new System.Drawing.Size(1658, 723);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.FinishedBox);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.deliveredBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "KitchenForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox deliveredBox;
        private System.Windows.Forms.TextBox timeBox;
        private System.Windows.Forms.TextBox FinishedBox;
        private System.Windows.Forms.Button Back;
    }
}