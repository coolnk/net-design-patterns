using System;


namespace BehaviouralPatterns_ChainOfResponsibility
{
    class HR : Handler
    {
        public override void Handle(Request request)
        {
            if(request.RequestType == RequestType.FRISKVÅRD)
            {
                Console.WriteLine("Sanna has fulfilled your request");
            }
            else
            {
                successor.Handle(request);
            }
        }
    }
}
