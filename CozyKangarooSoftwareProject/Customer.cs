
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureProject
{
    internal class Customer {

        private string name;
        private string id;
        private List<Order> orders;
        private int curOrder = 0;
        public Customer(String Id, String Name)
        {
            this.id = Id;
            this.name = Name;
            orders = new List<Order>();
        }



        public Order createOrder(String id, Payment payment)
        {
            Order newOrder = new Order(id, payment, 20);
            orders.Add(newOrder);
            return newOrder;
        }

        public Order getOrder(String id)
        {
            return orders.Find(x => x.Id == id);
        }

        public string Name { get => name; set => name = value; }
        public string Id { get => id; set => id = value; }
        internal List<Order> Orders { get => orders; set => orders = value; }
    }
}
