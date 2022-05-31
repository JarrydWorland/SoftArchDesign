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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Button Test");
            Customer customer = new Customer("0001", "Filip");
        }

		private void orderButton_Click(object sender, EventArgs e)
		{
            OrderForm orders = new OrderForm();
            this.Hide();
            orders.Show();

        }

		private void reservationButton_Click(object sender, EventArgs e)
		{
            Reservations reservations = new Reservations();
            this.Hide();
            reservations.Show();
        }

		private void staffButton_Click(object sender, EventArgs e)
		{
            StaffLogin logins = new StaffLogin();
            this.Hide();
            logins.Show();
        }
	}
}
