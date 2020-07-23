using System;
using System.Linq;

namespace Kata
{
    public class Calculator
    {
        public int Add(string number="")
        {
            if (string.IsNullOrEmpty(number))
            {
                return 0;                
            }

            var delimiters = new string[]{",", "\n"};
            var content = number;
            if (number.StartsWith("//"))
            {
                var parts = number.Split("\n");
                var customDelimiter = parts[0].Replace("//", "");
                content = parts[1];
                delimiters = new[] {customDelimiter};
            }

            if (content.Contains("-"))
            {
                throw new Exception("negatives not allowed: -2");
            }
            
            var myArray = content.Split(delimiters,StringSplitOptions.None).Select(int.Parse);
            return myArray.Sum();
        }
    }
}