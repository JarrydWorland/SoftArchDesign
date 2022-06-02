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
    public partial class OrderForm : Form
    {
        private List<MenuItem> items;
        private Order order;
        private lLogger logger;
        private MainMenu mainMenu;

        public List<MenuItem> Items { get => Items; set => Items = value; }
        public Order Order { get => order; set => order = value; }
        public lLogger Logger { get => logger; set => logger = value; }

        public OrderForm(Customer customer, List<MenuItem> items, MainMenu mainMenu, lLogger logger)
        {
            InitializeComponent();
            this.items = items;
            this.logger = logger;
            this.mainMenu = mainMenu;
            prompt.Hide();
            foreach (MenuItem item in items)
            {
                orderChecklist.Items.Add(item.Name);
            }
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(orderChecklist.SelectedItems.Count == 0)
            {
                prompt.Text = "Please select at least 1 item.";
            }
            else
            {
                Random rnd = new Random();
                int id = rnd.Next(1000, 9999);
                order = new Order(id.ToString(), null, 20);
                foreach (string s in orderChecklist.CheckedItems)
                {
                    var iFound = items.FirstOrDefault(x => x.Name == s);
                    if (iFound != null)
                    {
                        order.addItem(iFound);
                    }
                }
                mainMenu.Orders.Add(order);
                PaymentForm paymentForm = new PaymentForm(mainMenu, logger, order.totalSum());
                this.Hide();
                paymentForm.Show();
            }
            prompt.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu.Show();
        }

        private void orderChecklist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
