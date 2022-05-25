using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureProject
{
    internal class Reservation
    {
        private List<Table> tables;
        public Reservation()
        {
            tables = new List<Table>();
        }

        public Boolean bookTable(Table table)
        {
            if(!table.Booked)
            {
                table.Booked = true;
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
