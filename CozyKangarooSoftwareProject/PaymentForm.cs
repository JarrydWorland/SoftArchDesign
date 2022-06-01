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
    public partial class PaymentForm : Form
    {
        private Payment payment;
        private lLogger logger;
        private double sum;
        private MainMenu mainMenu;
        public PaymentForm(MainMenu mainMenu, lLogger logger, double sum)
        {
            this.logger = logger;
            this.sum = sum;
            this.mainMenu = mainMenu;
            InitializeComponent();
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            String name = NameBox.Text;
            ulong card = Convert.ToUInt64(CardNumberBox.Text);
            ushort year = Convert.ToUInt16(YearExpiryBox.Text);
            ushort month = Convert.ToUInt16(MonthExpiryBox.Text);
            ushort cvv = Convert.ToUInt16(CvvBox.Text);
            Payment payment = new OnlinePayment(name, card, month, year, cvv, sum, logger);
            if(payment.validatePayment())
            {
                this.Hide();
                mainMenu.Show();
            }
        }
    }
}
