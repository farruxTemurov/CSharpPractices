using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeGeneratorApp
{
    internal class CodeGenerator
    {
        public string name;
        public int dob;
        public string department;
        public string code;

        public string changedName()
        {
            return name.ToLower();
        }

        public int calcAge()
        {
            return 2026 - dob;
        }

        public string depInits()
        {
            string depCode = "";
            string[] words = department.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                depCode += words[i].Substring(0, 1);

            }
            return depCode.ToLower();
        }

        public int randomNum()
        {
            Random r = new Random();
            int num = r.Next(100, 999);
            return num;
        }
    }
}
