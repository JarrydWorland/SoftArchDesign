using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CozyKangarooSoftwareProject
{
    internal class ReservationLogger : lLogger
    {
        public void Log(string message, string dir)
        {
            DateTime date = DateTime.UtcNow.Date;
            String time = DateTime.Now.ToString("hh:mm");
            using (StreamWriter w = File.AppendText(dir))
            {
                w.WriteLine($"{message}. Date: ({date.ToString("dd/MM/yyyy")}), Time of reservation: ({time})");
            }
        }

        public void Log(string message)
        {
            throw new NotImplementedException();
        }
    }
}
