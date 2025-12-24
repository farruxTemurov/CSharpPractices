using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparisonOperators
{
    internal class StringAndInt
    {
        public void CalculateAge()
        {

            Console.WriteLine("Enter Your First Name: ");
            string fname = Console.ReadLine();

            int birthYear;
            int currentYear = DateTime.Now.Year;

            while (true)
            {
                Console.WriteLine("Enter Your Birth Year: ");
                string input = Console.ReadLine();
                if (!int.TryParse(input, out birthYear))
                {
                    Console.WriteLine("Please enter a valid number.");
                    continue; // asks the birth year again
                }

                if (birthYear <= 0 || birthYear > currentYear)
                {
                    Console.WriteLine($"Year must be between 1 and {currentYear}.");
                    continue;
                }

                // Valid input
                break;
            }
            int age = currentYear - birthYear;
            Console.WriteLine($"Hello {fname}, your age is {age}");

        }
    }
}
