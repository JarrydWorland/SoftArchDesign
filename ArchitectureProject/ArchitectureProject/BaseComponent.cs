using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureProject
{
    internal class BaseComponent
    {
        protected Mediator _mediator;

        public BaseComponent(Mediator mediator = null)
        {
            this._mediator = mediator;
        }

        public void SetMediator(Mediator mediator)
        {
            this._mediator = mediator;
        }
    }
}
