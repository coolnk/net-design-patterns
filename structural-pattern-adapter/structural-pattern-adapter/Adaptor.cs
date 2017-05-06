using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structural_pattern_adapter
{
    class Adaptor: Target
    {
        Adaptee adaptee;
        public Adaptor()
        {
            adaptee = new Adaptee();
        }

        public override void  Operation()
        {
            adaptee.Method();

        }
    }
}
