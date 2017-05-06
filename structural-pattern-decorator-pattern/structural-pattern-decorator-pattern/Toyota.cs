using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structural_pattern_decorator_pattern
{
    //The concrete component
    class Toyota : Car
    {
        public Toyota()
        {
            this.Name = "Toyota";
        }

        public override void Move()
        {
            Console.WriteLine("The toyota car is moving");
        }
    }
}
