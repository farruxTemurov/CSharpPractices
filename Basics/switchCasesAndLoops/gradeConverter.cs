using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchCasesAndLoops
{
    internal class gradeConverter
    {
        public void PrintGrades()
        {
            double polishGrade;
            String usaGrade;
            Console.Write("Enter your polish grade: ");
            polishGrade = Convert.ToDouble(Console.ReadLine());

            switch (polishGrade)
            {
                case 5: usaGrade = "A"; break;
                case 4.5: usaGrade = "B+"; break;
                case 4: usaGrade = "B"; break;
                case 3.5: usaGrade = "C+"; break;
                case 3: usaGrade = "C"; break;
                case 2: usaGrade = "F"; break;
                default: usaGrade = "Invalid grade"; break;
            }
            if (usaGrade == "Invalid grade")
            {
                Console.WriteLine("Your entered wrong value, please try again!");
            }
            else
            {
                Console.WriteLine("Your USA grade is " + usaGrade);
            }
        }
    }
}
