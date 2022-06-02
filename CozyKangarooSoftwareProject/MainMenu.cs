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

        private List<MenuItem> menuItems = new List<MenuItem>();
        private List<Order> orders = new List<Order>();
        private Customer customer;
        private lLogger logger;
        private BookingForm bookingForm;
        private OrderForm menu;
        private FoodMenu foodMenu;
        private KitchenForm kitchenForm;
        private WaitForm waitForm;
        public MainMenu()
        {
            InitializeComponent();
            //Initialize logger and payment
            lLogger cLogger = LoggerFactory.CreateLogger(LoggerFactory.LoggerType.Console);
            this.logger = cLogger;
            lLogger fLogger = LoggerFactory.CreateLogger(LoggerFactory.LoggerType.File);
            lLogger dLogger = LoggerFactory.CreateLogger(LoggerFactory.LoggerType.Database);
            lLogger rLogger = LoggerFactory.CreateLogger(LoggerFactory.LoggerType.Reservation);
            Payment lPayment = new LocalPayment("Filip", 1234213412341234, 1234, 16, fLogger);
            Payment cPayment = new CashPayment(1234, 16, cLogger);

            //Create some food for menu 
            MenuItem fries = new MenuItem("1", "Fries", "Our delicious cripsy fries", 5.99, "true", "380", "test_path");
            MenuItem brownie = new MenuItem("2", "Brownie", "Fresh brownie with moltem chocolate inside", 4.00, "true", "730", "test_path");
            MenuItem pizza = new MenuItem("3", "Pizza", "Pizza Carbonara", 18.20, "false", "1420", "test_path");
            MenuItem pasta = new MenuItem("4", "Pasta", "Pasta with prawns and our special souce", 21.00, "false", "1003", "test_path");
            MenuItem coffee = new MenuItem("5", "Coffee", "Freshly brewed coffee", 5.00, "true", "24", "test_path");
            MenuItem juice = new MenuItem("6", "Juice", "Orange juice squeezed this morning", 7.00, "true", "142", "test_path");

            menuItems.Add(fries);
            menuItems.Add(brownie);
            menuItems.Add(pizza);
            menuItems.Add(pasta);
            menuItems.Add(coffee);
            menuItems.Add(juice);

            Order order1 = new Order("1", null, 30);
            Order order2 = new Order("2", null, 20);
            Order order3 = new Order("3", null, 50);
            Order order4 = new Order("4", null, 60);
            Order order5 = new Order("5", null, 70);

            orders.Add(order1);
            orders.Add(order2);
            orders.Add(order3);
            orders.Add(order4);
            orders.Add(order5);


            customer = new Customer("001", "John");

            bookingForm = new BookingForm(this, fLogger);
            menu = new OrderForm(customer, MenuItems, this, Logger);
            foodMenu = new FoodMenu(MenuItems, this);
            kitchenForm = new KitchenForm(this);
            waitForm = new WaitForm(this);
        }

        public List<Order> Orders { get => orders; set => orders = value; }
        public lLogger Logger { get => logger; set => logger = value; }
        internal List<MenuItem> MenuItems { get => menuItems; set => menuItems = value; }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            foodMenu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            waitForm.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int i = 1;
            if (orders.Count > 0)
            {
                foreach (Order o in orders)
                {
                    foreach (MenuItem item in o.Items)
                    {
                        currentOrders.Items.Add("Order " + i + ". " + item.Name);
                    }
                    i++;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            bookingForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            kitchenForm.Show();
        }
    }
}
