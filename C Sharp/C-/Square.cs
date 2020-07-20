using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    class Square
    {
        private int area;
        private int length;

        public Square(int aLength)
        {
            length = aLength;
            area = areaCalculator(aLength);
        } 

        private int areaCalculator(int l)
        {
            return (l * l); 
        }

        public int Side
        {
            get { return length; }
        }

        public int Area
        {
            get { return area; }
        }
    }
}
