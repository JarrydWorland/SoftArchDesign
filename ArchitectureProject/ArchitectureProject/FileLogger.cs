using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureProject
{
    internal class FileLogger : lLogger
    {
        public void Log(string message)
        {
            using(StreamWriter w = File.AppendText("restaurantLog.log"))
            {
                w.WriteLine($"DateTime: {DateTime.Now}, Data: {message}");
            }
        }
    }
}
