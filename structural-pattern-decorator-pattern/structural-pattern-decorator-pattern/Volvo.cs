using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structural_pattern_decorator_pattern
{
    class Volvo :Car
    {
        public Volvo()
        {
            this.Name = "Volvo";
        }

        public override void  Move()
        {
            Console.WriteLine("The volvo is moving");
        }


    }
}
