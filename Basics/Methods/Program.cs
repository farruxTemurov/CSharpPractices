using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static int Add()
        {
            List<int> arr = new List<int>();
            string input;

            Console.WriteLine("Enter numbers (press X to calculate)");

            while (true)
            {
                Console.Write("Input number: ");
                input = Console.ReadLine();

                if (input.ToLower() == "x") break;

                arr.Add(int.Parse(input));
            }

            int sum = 0;
            foreach (int n in arr)
            {
                sum += n;
            }

            return sum;
        }

        static

        static void Menu()
        {
            int choice;
            String con;
            do
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1: Add numbers," +
                    " 2: Find a Combination of numbers");
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        int result = Add();
                        Console.WriteLine($"sum = {result}");
                        break;
                    default: Console.WriteLine("Wrong choice!"); break;
                }
                Console.WriteLine("Do you want to continue?(y/n)");
                con = Console.ReadLine();
            } while (con.Equals("y"));
            Console.WriteLine("Thanks for your visit!");
        }
        static void Main(string[] args)
        {
            Menu();
        }
    }
}
