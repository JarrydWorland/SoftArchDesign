using CozyKangarooSoftwareProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureProject
{
    internal class Customer : BaseComponent {

        private string name;
        private string id;
        private List<Order> order;
        private int curOrder = 0;
        public Customer(String Id, String Name)
        {
            this.id = Id;
            this.name = Name;
            order = new List<Order>();
        }
        public void DoA()
        {
            Console.WriteLine("Component 1 does A.");

            this._mediator.Notify(this, "A");
        }

        public void DoB()
        {
            Console.WriteLine("Component 1 does B.");

            this._mediator.Notify(this, "B");
        }


        public Boolean finishOrder(Payment payment)
        {
            if (order[curOrder].Local == true)
            {
                Console.WriteLine("Please provide card number: ");
                String num1 = Console.ReadLine();
                Console.WriteLine("Please provide card pin: ");
                String pin1 = Console.ReadLine();
                return payment.ValidatePayment(Convert.ToUInt64(num1), Convert.ToUInt16(pin1) );
            }
            Console.WriteLine("Please provide your name: ");
            String name = Console.ReadLine();
            Console.WriteLine("Please provide card number: ");
            String num2 = Console.ReadLine();
            Console.WriteLine("Please provide card expiry year: ");
            String yr = Console.ReadLine();
            Console.WriteLine("Please provide card expiry month: ");
            String mth = Console.ReadLine();
            Console.WriteLine("Please provide card ccv number: ");
            String ccv = Console.ReadLine();
            return payment.ValidatePayment(name, Convert.ToUInt64(num2), Convert.ToUInt16(mth), Convert.ToUInt16(yr), Convert.ToUInt16(ccv) );
        }

        public void createOrder(String id, Boolean local)
        {
            Order newOrder = new Order(id, local);
            order.Add(newOrder);
        }


        public Boolean addToOrder(MenuItem item)
        {
            if(order != null && item != null)
            {
                order[curOrder].Items.Add(item);
                return true;
            }
            return false;
        }

        public Boolean removeFromOrder(MenuItem item)
        {
            if (order[curOrder].Items.Contains(item) && order != null)
            {
                order[curOrder].Items.Remove(item);
                return true;
            }
            return false;
        }

        public Order showOrder()
        {
            if(order != null)
            {

                return order[curOrder];
            }
            return null;
        }

        public string Name { get => name; set => name = value; }
        public string Id { get => id; set => id = value; }
    }
}
