using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviouralPatterns_ChainOfResponsibility
{
    class VD : Handler
    {
        public override void Handle(Request request)
        {
            Console.WriteLine("What an outrageous request but I shall grant you your request");
        }

    }
}
