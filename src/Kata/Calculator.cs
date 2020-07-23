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
                        
            var myArray = number.Split(",").Select(int.Parse);
            return myArray.Sum();
        }
    }
}