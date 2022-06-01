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
    public partial class FoodMenu : Form
    {

        private MainMenu mainMenu;
        public FoodMenu(List<MenuItem> items, MainMenu mainMenu)
        {
            this.mainMenu = mainMenu;
            InitializeComponent();
            foreach (MenuItem item in items)
            {
                MenuView.Items.Add(item.Name);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu.Show();
        }
    }
}
