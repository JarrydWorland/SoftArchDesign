using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CozyKangarooSoftwareProject
{
    public interface lLogger
    {
        void Log(string message, string dir);
        void Log(string message);
    }
}
