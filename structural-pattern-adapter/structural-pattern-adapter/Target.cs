using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structural_pattern_adapter
{
    class Target
    {
        public virtual void Operation()
        {
            Console.WriteLine("The original operation");
        }
    }
}
