using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structural_pattern_decorator_pattern
{
    //The abstract component 
    abstract class Car
    {
        public string Name { get; set; }

        public abstract void Move();
    }
}
