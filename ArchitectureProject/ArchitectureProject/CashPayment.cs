using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureProject
{
    internal class CashPayment : Payment
    {
        private int givenSum;
        private bool succ;
        public CashPayment(int sum, int givenSum, lLogger logger) : base(sum, logger)
        {
        this.givenSum = givenSum;
        }

        public override void logPayment()
        {
            if(succ)
            {
                logger.Log($"Payment successfully made on: {DateTime.Now}. Amount: ${sum}.");
            }
            else
            {
                logger.Log($"Payment failed on: {DateTime.Now}. Amount: ${sum}.");
            }
        }

        public override bool validatePayment()
        {
            if(sum == givenSum)
            {
                succ = true;
                Console.WriteLine("Payment successful");
                return true;
            }
            else
            {
                double dif = sum - givenSum;
                if(dif < 0)
                {
                    succ = true;
                    Console.WriteLine($"Payment successful. Please give the change of total ${dif}");
                    return true;
                }
                else
                {
                    succ = false;
                    Console.WriteLine($"Payment failed. Client is missing ${dif}");
                }
            }
            return false;
        }
    }
}
