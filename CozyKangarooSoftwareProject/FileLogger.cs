using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CozyKangarooSoftwareProject
{
    internal class FileLogger : lLogger
    {
        public void Log(string message, string dir)
        {
            using(StreamWriter w = File.AppendText("C:\\Users\\filip\\source\\repos\\ArchitectureProject\\ArchitectureProject\\restaurantLog.txt"))
            {
                w.WriteLine($"DateTime: {DateTime.Now}, Data: {message}");
            }
        }

        public void Log(string message)
        {
            throw new NotImplementedException();
        }
    }
}
