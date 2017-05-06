using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structural_pattern_decorator_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Car toyotaCar = new Toyota();
            toyotaCar.Move();
            Car volvoCar = new Volvo();
            volvoCar.Move();

            Console.WriteLine("After pimping the two cars -----------");

            Car pimpedToyota = new PimpedCar(toyotaCar);
            Car pimpedVolvo = new PimpedCar(volvoCar);
            pimpedVolvo.Move();
            Console.ReadKey();
        }
    }
}
