namespace Kata
{
    public class Calculator
    {
        public int Add(string number="")
        {
            if (string.IsNullOrEmpty(number))
            {
                return 0;                
            }else if (number.Contains(","))
            {
                var myArray = number.Split(",");
                return int.Parse(myArray[0]) + int.Parse(myArray[1]);
            }

            return int.Parse(number);
        }
    }
}