using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    class Chef
    {
        public void makeFood()
        {
            Console.WriteLine("The chef is making food");
        }

        public void makeDessert()
        {
            Console.WriteLine("The chef is making dessert");
        }

        public virtual void makeSpecialDish()
        {
            Console.WriteLine("The chef is making special Dish Barayani");
        }
    }
}
