using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureProject
{
    internal class Table00002 : Table
    {
        public Table00002(String id, String name, String desc, String res, String size, Boolean booked) : base(id, name, desc, res, size, booked) { }
        private String dir = "C:\\Users\\filip\\source\\repos\\ArchitectureProject\\ArchitectureProject\\Table00002.txt";

        public override bool ValidateBooking(string date, string time)
        {
            foreach (string line in System.IO.File.ReadLines(dir))
            {
                if (!checkLine(line, date, time))
                {
                    return false;
                }
            }
            // Read the file and display it line by line.  

            return true;
        }

        public override bool BookTable(string time, string date, lLogger logger)
        {
            if (ValidateBooking(date, time))
            {
                logger.Log($"Date for booking: ({date}), Time for booking: ({time})", dir);
                return true;
            }
            return false;
        }
    }
}
