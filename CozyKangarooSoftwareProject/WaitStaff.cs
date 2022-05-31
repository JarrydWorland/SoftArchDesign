using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureProject
{
    internal class WaitStaff : Staff
    {
        public WaitStaff(string Id, string Login, string Password) : base(Id, Login, Password)
        {
        }

        public void deliverOrder(Order order)
        {
            order.Delivered = true;
        }
    }
}
