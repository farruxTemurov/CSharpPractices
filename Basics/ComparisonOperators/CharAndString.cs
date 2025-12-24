using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparisonOperators
{
    public class CharAndString
    {
        public void ReverseLetters()
        {
            char[] letters = new char[3];

            for (int i = 0; i < 3; i++)
            {
                string input;
                do
                {
                    Console.WriteLine($"Enter the letter number {i + 1}");
                    input = Console.ReadLine();

                    if (input.Length != 1)
                    {
                        Console.WriteLine("Please enter only ONE letter!");
                    }

                } while (input.Length != 1);

                letters[i] = input[0];

            }

            Array.Reverse(letters);
            string reversedLetters = new string(letters); // convert char to string
            Console.WriteLine($"Reversed order of letters are {reversedLetters}");
        }
    }
}
