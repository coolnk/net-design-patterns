using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviouralPatterns_ChainOfResponsibility
{
    class CEO : Handler
    {
     
        public override void Handle(Request request)
        {
            if (request.RequestType == RequestType.PERSONAL)
            {
                Console.WriteLine("The VD has granted your request");
            }
            else
            {
                successor.Handle(request);
            }
        }
    }
}
