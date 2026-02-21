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

                if (!int.TryParse(input, out int number))
                {
                    Console.WriteLine("Wrong input, please enter an integer");
                    continue;
                }

                arr.Add(int.Parse(input));
            }

            int sum = 0;
            foreach (int n in arr)
            {
                sum += n;
            }

            return sum;
        }

        static int findFactorial(int n)
        {
            int f = 1;
            for (int i = n; i >= 1; i--)
            {
                f *= i;
            }
            return f;
        }

        static int FindCombination(int n, int r)
        {
            return findFactorial(n) / (findFactorial(r) * findFactorial(n - r));
        }

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
                    case 2:
                        int r, n;
                        Console.Write("Enter the r value: ");
                        r = int.Parse(Console.ReadLine());

                        Console.Write("Enter the n value: ");
                        n = int.Parse(Console.ReadLine());
                        int comb = FindCombination(n, r);
                        Console.WriteLine("result is: " + comb);
                        break;
                    default: Console.WriteLine("Wrong choice!"); break;
                }
                Console.WriteLine("Do you want to continue?(y/n)");
                con = Console.ReadLine();
            } while (con.Equals("y", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Thanks for your visit!");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            //Menu();
            int x = 5, y = 10;
            Console.WriteLine($"Before swap: x = {x}, y = {y}");
            Swap(ref x, ref y);
            Console.WriteLine($"After swap: x = {x}, y = {y}");
            Console.ReadKey();
        }
    }
}
