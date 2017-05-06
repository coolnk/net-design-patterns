using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structural_pattern_adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Target target = new Target();
            target.Operation();

            Target target2 = new Adaptor();
            target2.Operation();
            Console.ReadKey();

        }
    }
}
