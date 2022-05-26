using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureProject
{
    internal class LoggerFactory
    {

        internal enum LoggerType
        {
            File,
            Console,
            Database
        }

        public static lLogger CreateLogger(LoggerType type)
        {
            lLogger logger = null;
            switch(type)
            {
                case LoggerType.Console:
                    logger = new ConsoleLogger();
                    break;
                case LoggerType.File:
                    logger = new FileLogger();
                    break;
                default:
                    logger = new FileLogger();
                    break;
            }

            return logger;

        }
    }
}
