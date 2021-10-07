using System;

namespace Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter word: ");
            string word = Console.ReadLine().Trim().ToLower();
            int lengthOfWord = word.Length;
            bool IsPalindrom = true;

            for (int i = 0; i < lengthOfWord/2; i++)
            {
                if (word[i]!=word[lengthOfWord-1-i])
                {
                    IsPalindrom = false;
                }
            }

            if (IsPalindrom==true)
            {
                Console.WriteLine("The word {0} is Palindrom",word);
            }
            else
            {
                Console.WriteLine("The word {0} is  Not Palindrom", word);
            }
        }
    }
}
