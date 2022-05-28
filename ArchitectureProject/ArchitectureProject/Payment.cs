using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureProject
{
    public abstract class Payment
    {
        public string name;
        public ulong cardNumber;
        public ushort expMonth;
        public ushort expYear;
        public ushort cvv;
        public ushort pin;
        public double sum;
        public lLogger logger;
        public Payment(string Name, ulong cardNumber, ushort expMonth, ushort expYear, ushort cvv, double sum, lLogger logger)
        {
            this.name = Name;
            this.cardNumber = cardNumber;
            this.expMonth = expMonth;
            this.expYear = expYear;
            this.cvv = cvv;
            this.sum = sum;
            this.logger = logger;
        }

        public Payment(string Name, ulong cardNumber, ushort pin, double sum, lLogger logger)
        {
            this.name = Name;
            this.cardNumber = cardNumber;
            this.pin = pin;
            this.sum = sum;
            this.logger = logger;
        }

        public Payment(double sum, lLogger logger)
        {
            this.sum = sum;
            this.logger = logger;
        }

        public abstract bool validatePayment();
        public abstract void logPayment();
    }
}
