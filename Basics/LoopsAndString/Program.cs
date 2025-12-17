using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsAndString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReplaceMethod rm = new ReplaceMethod();

            string text = "Hello world";
            string output = rm.ReplaceWord(text, "world", "Everyone");

            Console.WriteLine(output);
        }
    }
}
