using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureProject
{
    public interface Mediator
    {
        void Notify(object sender, string ev);
    }

    class ConcreteMediator : Mediator
    {
        private Customer customer;

        private Order order;

        public ConcreteMediator(Customer customer, Order order)
        {
            this.customer = customer;
            this.customer.SetMediator(this);
            this.order = order;
            this.order.SetMediator(this);
        }

        public void Notify(object sender, string ev)
        {
            if (ev == "A")
            {
                Console.WriteLine("Mediator reacts on A and triggers folowing operations:");
                this.order.DoC();
            }
            if (ev == "D")
            {
                Console.WriteLine("Mediator reacts on B and triggers following operations:");
                this.customer.DoB();
                this.order.DoC();
            }
        }
    }
}
