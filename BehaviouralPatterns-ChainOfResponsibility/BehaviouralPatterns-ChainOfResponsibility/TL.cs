using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviouralPatterns_ChainOfResponsibility
{
    class TL : Handler
    {
        public override void Handle(Request request)
        {
            if( request.RequestType == RequestType.TEAMACTIVITY)
            {
                Console.WriteLine("Team Leader has granted your request for team activity");
            }
            else
            {
                successor.Handle(request);
            }
        }
    }
}
