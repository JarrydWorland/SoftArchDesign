using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CozyKangarooSoftwareProject
{
    internal class OnlinePayment : Payment
    {

        private bool succ;
        public OnlinePayment(string Name, ulong cardNumber, ushort expMonth, ushort expYear, ushort cvv, double sum, lLogger logger) : base(Name, cardNumber, expMonth, expYear, cvv, sum, logger)
        {
            succ = false;
        }

        public override void logPayment()
        {
            if (succ)
            {
                logger.Log($"Online payment successfully made on: {DateTime.Now} under the name {name}. Amount: ${sum}.");
            }
            else
            {
                logger.Log($"Online payment failed on: {DateTime.Now} under the name {name}. Amount: ${sum}.");
            }
        }

        public override bool validatePayment()
        {
            if (cardNumber < 1000000000000000 || cardNumber > 9999999999999999)
            {
                Console.WriteLine("Payment Details Invalid");
                logPayment();
                return false;
            }
            if (expMonth < 1 || expMonth > 12)
            { 
                Console.WriteLine("Payment Details Invalid");
                logPayment();
                return false;
            }
            if (expYear < 22 || expYear > 99)
            {
                Console.WriteLine("Payment Details Invalid");
                logPayment();
                return false;
            }
            if (cvv < 100 || cvv > 999)
            {
                Console.WriteLine("Payment Details Invalid");
                logPayment();
                return false;
            }
            Console.WriteLine("Payment Details Valid");
            succ = true;
            logPayment();
            return true;
        }
    }
}
