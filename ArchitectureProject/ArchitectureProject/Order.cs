using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureProject
{
    internal class Order : BaseComponent
    {
        private string id;
        private List<MenuItem> items;
        private Boolean local;
        public Order(String Id, Boolean Local)
        {
            this.id = Id;
            this.local = Local;
            items = new List<MenuItem>();
        }

        public string Id { get => id; set => id = value; }
        public List<MenuItem> Items { get => items; set => items = value; }
        public bool Local { get => local; set => local = value; }

        public void DoC()
        {
            Console.WriteLine("Component 2 does C.");

            this._mediator.Notify(this, "C");
        }

        public void DoD()
        {
            Console.WriteLine("Component 2 does D.");

            this._mediator.Notify(this, "D");
        }
    }
}
