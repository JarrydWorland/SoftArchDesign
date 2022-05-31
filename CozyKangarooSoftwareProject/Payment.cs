using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CozyKangarooSoftwareProject
{
    public class Payment
    {
        public bool valid = false;
        public bool check = true;
        public bool loloop = false;
        public bool ValidatePayment(string name, ulong cardNumber, byte expMonth, byte expYear, ushort cvv)
        {

            Console.WriteLine("Sending Details");
            CheckData(cardNumber, expMonth, expYear, cvv);

            return true;
        }

        public bool ValidatePayment(ulong cardNumber, ushort pin)
        {
            Console.WriteLine("Sending Details");
            CheckData(cardNumber, pin);
            return true;
        }

        public bool CheckData(ulong cardNumber, byte expMonth, byte expYear, ushort cvv)
        {
                if (cardNumber < 1000000000000000 && cardNumber > 9999999999999999)
                {
                    check = false;
                    Console.WriteLine("Payment Details Invalid");
                    return false;
                }
                if (expMonth < 1 && expMonth > 12)
                {
                    check = false;
                    Console.WriteLine("Payment Details Invalid");
                    return false;
                }
                if (expYear < 22 && expYear > 99)
                {
                    check = false;
                    Console.WriteLine("Payment Details Invalid");
                    return false;
                }
                if (cvv < 100 && cvv > 999)
                {
                    check = false;
                    Console.WriteLine("Payment Details Invalid");
                    return false;
                }

                Console.WriteLine("Payment Details Valid");
                return true;

        }

        public bool CheckData(ulong cardNumber, ushort pin)
        {
                if (cardNumber < 1000000000000000 && cardNumber > 9999999999999999)
                {
                    check = false;
                    Console.WriteLine("Payment Details Invalid");
                    return false;
                }

                if (pin < 1000 && pin > 9999)
                {
                    check = false;
                    Console.WriteLine("Payment Details Invalid");
                    return false;
                }

                if (check == true)
                {
                    loloop = true;
                    Console.WriteLine("Payment Details Valid");
                    return true;
                }

                return false;
        }
    }
}
