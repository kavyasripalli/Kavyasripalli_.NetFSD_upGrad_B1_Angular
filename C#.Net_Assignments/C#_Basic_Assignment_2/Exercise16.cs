using System;

public class Exercise16
{
    public static void Run()
    {
        string word;

        Console.Write("Enter a word: ");
        word = Console.ReadLine();

        if (string.IsNullOrEmpty(word))
        {
            Console.WriteLine("Invalid input");
            return;
        }

        Console.WriteLine("Length of the word = " + word.Length);
    }
}