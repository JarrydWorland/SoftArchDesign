using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureProject
{
    abstract class Table
    {
        //Table booking holds for 2 hours
        private string id;
        private string name;
        private string desc;
        private string res;
        private string size;
        private bool booked;


        public Table(String id, String name, String desc, String res, String size, Boolean booked)
        {
            this.id = id;
            this.name = name;
            this.desc = desc;
            this.res = res;
            this.size = size;
            this.booked = booked;
        }

        public abstract bool BookTable(String time, String date, lLogger logger);

        public bool checkLine(String line, String date, String time)
        {
            String[] str = line.Split('(', ')');

            Console.WriteLine("Date read in file: " + str[1]);
            Console.WriteLine("Time read in file: " + str[3]);
            if (str[1] == date)
            {
                String[] bTime1 = time.Split(':');
                int bTime2 = Int32.Parse(bTime1[0]);
                String[] cTime1 = str[3].Split(':');
                int cTime2 = Int32.Parse(cTime1[0]);
                Console.WriteLine("Time we want booking: " + bTime2);
                Console.WriteLine("Time there is a booking in file: " + cTime2);
                if (bTime2 == cTime2 || bTime2 == cTime2 + 1)
                {
                    return false;
                }
            }
            // Read the file and display it line by line.  

            return true;
        }

        public abstract bool ValidateBooking(String date, String time);



        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Desc { get => desc; set => desc = value; }
        public string Res { get => res; set => res = value; }
        public string Size { get => size; set => size = value; }
        public bool Booked { get => booked; set => booked = value; }
    }
}
