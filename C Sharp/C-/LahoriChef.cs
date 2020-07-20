using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    class LahoriChef : Chef
    {
        public void makeBarBQ()
        {
            Console.WriteLine("Chef is making BBQ");
        }

        public override void makeSpecialDish()
        {
            Console.WriteLine("Lahori Special Dish");
        }
    }
}
