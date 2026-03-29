using System;

public class Exercise18
{
    public static void Run()
    {
        string word1, word2;

        Console.Write("Enter first word: ");
        word1 = Console.ReadLine();

        Console.Write("Enter second word: ");
        word2 = Console.ReadLine();

        if (string.IsNullOrEmpty(word1) || string.IsNullOrEmpty(word2))
        {
            Console.WriteLine("Invalid input");
            return;
        }

        if (word1 == word2)
        {
            Console.WriteLine("Both words are the same");
        }
        else
        {
            Console.WriteLine("Words are different");
        }
    }
}