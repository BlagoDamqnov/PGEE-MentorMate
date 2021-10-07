using System;

namespace NumberReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num: ");
            int number = int.Parse(Console.ReadLine());
            int reverve = 0;
            int newNum = number;

            while (number>0)
            {
                int lastNum = number % 10;
                reverve = reverve * 10 + lastNum;
                number = number / 10;
            }
            Console.WriteLine("The reverse Number is: {0} => {1}",newNum,reverve);
        }
    }
}
