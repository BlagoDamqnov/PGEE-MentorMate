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
                while (arrayOfnumber[i]==arrayOfnumber.Length)
                {
                    if (!(arrayOfnumber[i] >= -99.99 &&
                   arrayOfnumber[i] <= 99.99))
                    {
                        Console.WriteLine("Enter number again between -99.99 and 99.99.");
                        arrayOfnumber[i] = double.Parse(Console.ReadLine());

                    }
                    else
                    {
                        SortBubble(arrayOfnumber);
                       
                    }
                }
               
            }

            Console.WriteLine();

            SortBubble(arrayOfnumber);

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(arrayOfnumber[i]);
            }
        }
        public static void SortBubble(double[] arr)
        {
            for (int i = 0; i < arr.Length-1 ; i++)
            {
                for (int j = 0; j < arr.Length-1 ; j++)
                {
                    if (arr[j]>arr[j+1])
                    { 
                        double temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                   
                }
            }

        }
    }

}
