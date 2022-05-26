using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureProject
{
    internal class ConsoleLogger : lLogger
    {
        public void Log(string message)
        {
                Console.WriteLine($"DateTime: {DateTime.Now}, Data: {message}");
        }
    }
}
