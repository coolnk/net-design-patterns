using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structural_pattern_decorator_pattern
{
    //The decorator 
    class PimpedCar: Car
    {
        Car _pimpedCar; 
        public PimpedCar( Car car)
        {
            _pimpedCar = car;
        }

        public override void Move()
        {
            Console.WriteLine("This "+_pimpedCar.Name + " is pimped");
            _pimpedCar.Move();
        }

    }
}
