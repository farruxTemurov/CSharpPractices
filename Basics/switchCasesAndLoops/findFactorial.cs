using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchCasesAndLoops
{
    internal class findFactorial
    {
        public static int Calculate(int num)
        {
            int f = 1;
            for (int i = num; i >= 1; i--)
                f *= i;
            return f;
        }
    }
}
