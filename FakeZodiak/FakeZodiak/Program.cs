using System;
using System.Text;

namespace FakeZodiak
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter FirstName: ");
            string name = Console.ReadLine().Trim();

            Console.Write("Enter SecondName: ");
            string secondName = Console.ReadLine().Trim();

            Console.Write("Enter LastName: ");
            string lastName = Console.ReadLine().Trim();

            Console.Write("Enter date of birth:");
            int dateofbirth = int.Parse(Console.ReadLine());

            Console.Write("Enter month of birth:");
            int monthofbirth = int.Parse(Console.ReadLine());

            Console.Write("Enter year of birth:");
            int yearofbirth = int.Parse(Console.ReadLine());

            int totalSum = 0;

            int lenghtofName = name.Length + secondName.Length + lastName.Length;

            while (lenghtofName> 0 || totalSum > 9)
            {
                if (lenghtofName == 0)
                {
                    lenghtofName = totalSum;
                    totalSum = 0;
                }
                totalSum += lenghtofName % 10;
                lenghtofName =lenghtofName/ 10;
            }

            int resultSumofBirth = dateofbirth + monthofbirth + yearofbirth;

            string[] phrases = new string[] {"You will be healthy.","You will be successful","You will have money.","You will live long.","You will have many children.",
                                             "You will have a nice house.","You will have a long relationship",
                                             "You will have a good job.","You will live abroad.","You will be smart" };


            int phrasesResult = resultSumofBirth % 10;

            switch (totalSum)
            {
                case 1:
                    {
                         Console.WriteLine("Тhe sum of name is: {0} that mean: {1}",totalSum,phrases[totalSum]);
                           break;
                    }
                case 2:
                    {
                        Console.WriteLine("Тhe sum of name is: {0} that mean: {1}", totalSum, phrases[totalSum]);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Тhe sum of name is: {0} that mean: {1}", totalSum, phrases[totalSum]);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Тhe sum of name is: {0} that mean: {1}", totalSum, phrases[totalSum]);
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Тhe sum of name is: {0} that mean: {1}", totalSum, phrases[totalSum]);
                        break; 
                    }
                case 6:
                    {
                        Console.WriteLine("The sum of name is: {0} that mean: {1}", totalSum, phrases[totalSum]);
                        break;
                    }

                  case 7:
                    {
                        Console.WriteLine("Тhe sum of name is: {0} that mean: {1}", totalSum, phrases[totalSum]);
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine("Тhe sum of name is: {0} that mean: {1}", totalSum, phrases[totalSum]);
                        break;
                    }
                case 9:
                    {
                        Console.WriteLine("Тhe sum of name is: {0} that mean: {1}", totalSum, phrases[totalSum]);
                        break;
                    }
            }
            Console.WriteLine("The sum of birth is: {0} that means: {1}",resultSumofBirth,phrases[phrasesResult]);

        }
    }
}
