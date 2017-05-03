using System;


namespace BehaviouralPatterns_ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Request buyMeALambourghiniRequest = new Request(RequestType.PERSONAL);
            TL hannaHagalundEriksson = new TL();
            HR sannaJohanson = new HR();
            CEO rasmusKjellman = new CEO();
            VD andersLentill = new VD();

            sannaJohanson.SetHandler(hannaHagalundEriksson);
            hannaHagalundEriksson.SetHandler(rasmusKjellman);
            rasmusKjellman.SetHandler(andersLentill);

            sannaJohanson.Handle(buyMeALambourghiniRequest);

            Console.ReadKey();

        }
    }
}
