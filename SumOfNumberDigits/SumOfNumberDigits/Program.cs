using System;

namespace SumOfNumberDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 769;
            string numberSum = number.ToString();
            int newNumber = 0;

            foreach (var c in numberSum)
            {
                newNumber += int.Parse(c.ToString());
                Console.Write(c.ToString().TrimEnd('+') + "+");
            }

          
        }
    }
}
