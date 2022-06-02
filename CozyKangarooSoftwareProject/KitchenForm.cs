using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CozyKangarooSoftwareProject
{
    public partial class KitchenForm : Form
    {
        private MainMenu mainMenu;
        private KitchenStuff kitchenStuff;
        public KitchenForm(MainMenu mainMenu)
        {
            InitializeComponent();
            kitchenStuff = new KitchenStuff("333", "pass", "login");
            this.mainMenu = mainMenu;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = inputBox.Text;
            var result = mainMenu.Orders.FirstOrDefault(x => x.Id == id);
            if (result != null)
            {
                kitchenStuff.increaseTime(result, 10);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = inputBox.Text;
            var result = mainMenu.Orders.FirstOrDefault(x => x.Id == id);
            if (result != null)
            {
                kitchenStuff.decreaseTIme(result, 10);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = inputBox.Text;
            var result = mainMenu.Orders.FirstOrDefault(x => x.Id == id);
            if (result != null)
            {
                kitchenStuff.completeOrder(result);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string id = inputBox.Text;
            var result = mainMenu.Orders.FirstOrDefault(x => x.Id == id);
            if (result != null)
            {
                idBox.Text = result.Id;
                timeBox.Text = result.Time.ToString();
                deliveredBox.Text = result.Delivered.ToString();
                FinishedBox.Text = result.Finished.ToString();
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu.Show();
        }

        private void FinishedBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void timeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void deliveredBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void idBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void inputBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
