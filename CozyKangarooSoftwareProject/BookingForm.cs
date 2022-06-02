using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CozyKangarooSoftwareProject
{
    public partial class BookingForm : Form
    {
        private Reservation reservation;
        private string dateTime;
        private List<Table> tables;
        private MainMenu mainMenu;
        private lLogger logger;
        public BookingForm(MainMenu mainMenu, lLogger logger)
        {
            InitializeComponent();
            timePicker.Format = DateTimePickerFormat.Custom;
            timePicker.CustomFormat = "Pick: HH";
            timePicker.ShowUpDown = true;
            this.logger = logger;
            this.mainMenu = mainMenu;

            Table testTable2 = new Table00002("1234", "Table for 2", "123", "123", "123", true);
            Table testTable1 = new Table00001("4321", "Table for 1", "123", "123", "123", true);
            tables = new List<Table>();
            tables.Add(testTable1);
            tables.Add(testTable2);
            foreach (Table t in tables)
            {
                tableBox.Items.Add(t.Name);
            }
            prompt.Hide();
        }

        private void BookingForm_Load(object sender, EventArgs e)
        {

        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine(datePicker.Value.ToString("dd/MM/yyyy"));
        }

        private void timePicker_ValueChanged(object sender, EventArgs e)
        { 
            var splitted = Regex.Split(timePicker.Value.ToString(), ":");
            Console.WriteLine(splitted[0]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var iFound = tables.FirstOrDefault(x => x.Name == tableBox.SelectedItem);
            if (iFound != null)
            {

                var splitted = Regex.Split(timePicker.Value.ToString(), " ");
                if(iFound.BookTable(splitted[1], datePicker.Value.ToString("dd/MM/yyyy"), logger))
                {
                    prompt.Text = "Booking successful";
                }
                else
                {
                    prompt.Text = "Booking failure";
                }
            }
            else
            {
                prompt.Text = "Booking failure";
            }
            prompt.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
