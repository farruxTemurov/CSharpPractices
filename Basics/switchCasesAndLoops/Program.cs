using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchCasesAndLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            String con;
            gradeConverter gc = new gradeConverter();
            findFactorial f = new findFactorial();
            do
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1: Convert grades," +
                    " 2: Find a factorial of a number");
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1: gc.PrintGrades(); break;
                    case 2: f.findFactorialN(); break;
                    default: Console.WriteLine("Wrong choice!"); break;
                }
                Console.WriteLine("Do you want to continue?(y/n)");
                con = Convert.ToString(Console.ReadLine());
            } while (con.Equals("y"));
            Console.WriteLine("Thanks for your visit!");
        }
    }
}
