using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CozyKangarooSoftwareProject
{
    internal class DatabaseLogger : lLogger
    {
        public void Log(string message, string dir)
        {

                Console.WriteLine("Out of scope, just to show how factory pattern could be used for it.");
        }

        public void Log(string message)
        {
            throw new NotImplementedException();
        }
    }
}
