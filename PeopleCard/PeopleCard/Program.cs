using System;
using System.Linq;

namespace PeopleCard
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] card =  { "2 Spade","2 Diamond","2 Heart","2 Club","3 Spade","3 Diamond","3 Heart","3 Club","4 Spade","4 Diamond","4 Heart","4 Club","5 Spade","5 Diamond","5 Heart","5 Club","6 Spade","6 Diamond","6 Heart","6 Club","7 Spade","7 Diamond","7 Heart","7 Cub","8 Spade","8 Diamond","8 Heart","8 Club","9 Spade","9 Diamond","9 Heart","9 Club" +
                "10 Spade","10 Diamond","10 Heart","10 Club","J Spade","J Diamond","J Heart","J Club","Q Spade","Q Diamond","Q Heart","Q Club","K Spade","K Diamond","K Heart","K Club","A Spade","A Diamond","A Heart","A Club"};
            int player = 1;
            var ran = new Random();
            var razdavane = card.OrderBy(card => ran.Next());
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Player {0} has:", player);
                Console.WriteLine(string.Join(";", razdavane.Skip(13).Take(13).Distinct()));
                player++;
                Console.WriteLine();
            }
        }
    }
}
