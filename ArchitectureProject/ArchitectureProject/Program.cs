
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var result = $"Factory was implemented at {DateTime.Now}";
            lLogger logger = LoggerFactory.CreateLogger(LoggerFactory.LoggerType.Console);
            Payment payment = new LocalPayment("Filip", 1234213412341234, 1234, 16, logger);
            payment.validatePayment();
            //logger.Log(result);

            Console.ReadLine(); 

        }


    }

}
