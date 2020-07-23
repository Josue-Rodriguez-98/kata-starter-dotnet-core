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
            var myArray = number.Split(delimiters,StringSplitOptions.None).Select(int.Parse);
            return myArray.Sum();
        }
    }
}