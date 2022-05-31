using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureProject
{
    internal class LocalPayment : Payment
    {
        private bool succ;
        public LocalPayment(string Name, ulong cardNumber, ushort pin, int sum, lLogger logger) : base(Name, cardNumber, pin, sum, logger)
        {
            succ = false;
        }

        public override void logPayment()
        {
            if (succ)
            {
                logger.Log($"Local payment successfully made on: {DateTime.Now} under the name {name}. Amount: ${sum}.");
            }
            else
            {
                logger.Log($"Local payment failed on: {DateTime.Now} under the name {name}. Amount: ${sum}.");
            }
        }

        public override bool validatePayment()
        {
            if (cardNumber < 1000000000000000 && cardNumber > 9999999999999999)
            {
                Console.WriteLine("Payment Details Invalid");
                logPayment();
                return false;
            }

            if (pin < 1000 && pin > 9999)
            {
                Console.WriteLine("Payment Details Invalid");
                logPayment();
                return false;
            }
            Console.WriteLine($"Payment successful for ${sum}");
            succ = true;
            logPayment();
            return true;
        }
    }
}
