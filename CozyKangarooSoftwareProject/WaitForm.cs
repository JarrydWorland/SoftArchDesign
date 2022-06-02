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
    public partial class WaitForm : Form
    {
        private MainMenu mainMenu;
        private WaitStaff waitStaff;
        public WaitForm(MainMenu mainMenu)
        {
            InitializeComponent();
            this.mainMenu = mainMenu;
            waitStaff = new WaitStaff("333", "pass", "login");
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

        private void button2_Click(object sender, EventArgs e)
        {
            string id = inputBox.Text;
            var result = mainMenu.Orders.FirstOrDefault(x => x.Id == id);
            if (result != null)
            {
                waitStaff.increaseTime(result, 10);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = inputBox.Text;
            var result = mainMenu.Orders.FirstOrDefault(x => x.Id == id);
            if (result != null)
            {
                waitStaff.decreaseTIme(result, 10);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = inputBox.Text;
            var result = mainMenu.Orders.FirstOrDefault(x => x.Id == id);
            if (result != null && result.Finished == true)
            {
                waitStaff.deliverOrder(result);
            }
            else
            {
                Console.WriteLine("Order is not finished yet. Can't be delivered");
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu.Show();
        }
    }
}
