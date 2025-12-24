using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace ComparisonOperators
{
    internal class IntegerAndFloat
    {
        public void ReadTwoVals()
        {
            Console.Write("Enter an integer: ");
            int val1 = int.Parse(Console.ReadLine());

            Console.Write("Enter a floating number: ");
            float val2 = float.Parse(Console.ReadLine());

            if(val1 == val2)
            {
                Console.WriteLine($"{val1} and {val2} are equal");
            } else if(val1 > val2)
            {
                Console.WriteLine($"{val1} is greater than {val2}");
            } else
            {
                Console.WriteLine($"{val1} is less than {val2}");
            }

                float difference = Math.Abs(val1 - val2);

            if (difference < 0.1)
            {
                Console.WriteLine("These two values are approximately equal");
            }
            else
            {
                Console.WriteLine($"The difference between the two numbers is {difference}");
            }
        }
    }
}
