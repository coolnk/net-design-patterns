using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviouralPatterns_ChainOfResponsibility
{
    abstract class Handler
    {
        protected Handler successor;

        public void SetHandler(Handler successor)
        {
            this.successor = successor;
        }
        public abstract void Handle(Request request);      

    }
}
