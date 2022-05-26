
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
