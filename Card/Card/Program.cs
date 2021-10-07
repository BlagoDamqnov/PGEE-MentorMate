using System;

namespace Card
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] card = new string[] { "2","3","4","5","6","7","8","9","10","Aso","Vale","Dama","Pop"};
            string[] faces = new string[] { "Spatiq", "Karo", "Kypa", "Pika" };

            for (int i = 0; i < card.Length; i++)
            {
                for (int j = 0; j < faces.Length; j++)
                {
                  
                    Console.Write(" {0}   {1}   ",card[i],faces[j]);
                    Console.WriteLine();
                   
                }
                Console.WriteLine();
            }
        }
    }
}
