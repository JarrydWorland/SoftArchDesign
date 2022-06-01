using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CozyKangarooSoftwareProject
{
    internal class Reservation
    {
        private List<Table> tables;
        public Reservation(List<Table> tables)
        {
            this.tables = tables;
        }

        public Boolean bookTable(Table table)
        {
            if(!table.Booked)
            {
                table.Booked = true;
                Console.WriteLine("Booking successfull");
                return true;
            }
            Console.WriteLine("Table is already booked");
            return false;
        }

        public List<Table> showTables()
        {
            return tables;
        }
    }
}
