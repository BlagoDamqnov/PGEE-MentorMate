using System;

namespace FuzzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <=100; i++)
            {
                if (i%3==0&&i%5==0)
                {
                    Console.WriteLine(i+": "+"FuzzBuzz");
                }
                else if (i%3==0)
                {
                    Console.WriteLine(i+ ": "+"Fuzz");
                }
                else if (i%5==0)
                {
                    Console.WriteLine(i+ ": "+"Buzz");
                }
            }
        }
    }
}
