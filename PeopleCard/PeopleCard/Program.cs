using System;
using System.Linq;

namespace PeopleCard
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] card =  { "2S","2K","2KU","2P","3S","3K","3KU","3P","4S","4K","4KU","4P","5S","5K","5KU","5P","6S","6K","6KU","6P","7S","7K","7KU","7P","8S","8K","8KU","8P","9S","9K","9KU","9P" +
                "10S","10K","10KU","10P","ValeS","ValeK","VAleKU","ValeP","DamaS","DamaK","DamaKU","DamaP","PopS","PopK","PopKU","PopP","AsoS","AsoK","AsoKU","AsoP"};
            int player = 1;
            var ran = new Random();
            var razdavane = card.OrderBy(card => ran.Next());
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Player {0} has:", player);
                Console.WriteLine(string.Join(", ", razdavane.Take(13).Distinct()));
                player++;
                Console.WriteLine();
            }
        }
    }
}
