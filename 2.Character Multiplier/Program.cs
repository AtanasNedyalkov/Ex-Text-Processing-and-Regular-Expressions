using System;

namespace _2.Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split();
            string firstWord = tokens[0];
            string secondWord = tokens[1];

            string longerWord = string.Empty;
            string shorterWord = string.Empty;

            int totalSum = 0;
            if (firstWord.Length>=secondWord.Length)
            {
                firstWord = longerWord;
                secondWord = shorterWord;
            }
            else
            {
                firstWord = shorterWord;
                secondWord = longerWord;
            }
            for (int i = 0; i < shorterWord.Length; i++)
            {
                totalSum += longerWord[i] * shorterWord[i];
            }
            for (int i = shorterWord.Length; i < longerWord.Length; i++)
            {
                totalSum += longerWord[i];
            }
            Console.WriteLine(totalSum);
        }
    }
}
