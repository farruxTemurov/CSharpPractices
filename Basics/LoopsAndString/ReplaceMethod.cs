using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsAndString
{
    public class ReplaceMethod
    {
        public string ReplaceWord(string input, string search, string replacement)
        {
            string result = "";
            int i = 0;

            while (i <= input.Length - search.Length)
            {
                if (input.Substring(i, search.Length) == search)
                {
                    result += replacement;
                    i += search.Length;
                }
                else
                {
                    result += input[i];
                    i++;
                }
            }

            while (i < input.Length)
            {
                result += input[i];
                i++;
            }
            return result;
        }
    }
}
