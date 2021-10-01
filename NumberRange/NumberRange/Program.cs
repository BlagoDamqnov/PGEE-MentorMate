using System;

namespace NumberRange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter count of number: ");

            int count = int.Parse(Console.ReadLine());

            double[] arrayOfnumber = new double[count];

            for (int i = 0; i < count; i++)
            {
                arrayOfnumber[i] = double.Parse(Console.ReadLine());
                if (arrayOfnumber[i]>=-99.99 &&
                    arrayOfnumber[i]<=99.99)
                {
                   
                }
                else
                {
                    Console.WriteLine("Enter number again between -99.99 and 99.99.");
                    arrayOfnumber[i] = double.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();

            Array.Sort(arrayOfnumber);

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(arrayOfnumber[i]);
            }
        }
    }
}
