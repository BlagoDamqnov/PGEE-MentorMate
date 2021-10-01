using System;
using System.Collections;
using System.Linq;

namespace ReverseArray_Debugging
{


    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length of array:");
           int count = int.Parse(Console.ReadLine());

            int []arr = new int[count];

            for (int i = 0; i < count; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine();

            Console.Write("The sorted array is: ");
            foreach (var item in arr)
            {
                Console.Write(item+" ");
            }
        }
    }
}
