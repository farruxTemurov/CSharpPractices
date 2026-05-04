using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_calculator
{
    internal class Rectangle
    {
        private int a;
        public int A
        {
            set { a = value >= 0 ? value : -value; }
            get { return a; }
        }

        private int b;
        public int B
        {
            set { b = value >= 0 ? value : -value; }
            get { return b; }
        }

        public int Area()
        {
            return a * b;
        }
    }
}
