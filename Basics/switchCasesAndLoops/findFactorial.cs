using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchCasesAndLoops
{
    internal class findFactorial
    {
        public void findFactorialN()
        {
            int num;
            Console.Write("Please enter the n value: ");
            num = Convert.ToInt32(Console.ReadLine());
            int f = 1;

            for (int i = num; i >= 1; i--)
            {
                f *= i;
            }
            Console.WriteLine($"The factorial of {num} is " + f);
        }
    }
}
