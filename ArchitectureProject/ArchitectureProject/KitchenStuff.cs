using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureProject
{
    internal class KitchenStuff : Staff
    {
        public KitchenStuff(string Id, string Login, string Password) : base(Id, Login, Password)
        {
        }

        public void completeOrder(Order order)
        {
            order.Finished = true;
        }
    }
}
