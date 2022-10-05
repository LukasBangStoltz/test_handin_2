using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Functions
    {
        public static string ReverseString(string text)
        {
            string result = string.Empty;
            var test = text.Length;
            for (int i = text.Length -1; i >= 0; i--)
            {
                result += text[i];
            }
            return result;
        }

        public static String CapitalizeString(String input)
        {
            String output = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 'a' && input[i] <= 'z')
                {
                    output += (char)(input[i] - 'a' + 'A');
                }
                else
                    output += input[i];
            }
            return output;
        }
        public static String LowerString(String input)
        {
            String output = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 'A' && input[i] <= 'Z')
                {
                    output += (char)(input[i] - 'A' + 'a');
                }
                else
                    output += input[i];
            }
            return output;
        }


    }
}
