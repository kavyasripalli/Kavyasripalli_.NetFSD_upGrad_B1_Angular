using System;

public class Exercise17
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

        string reversed = "";

        for (int i = word.Length - 1; i >= 0; i--)
        {
            reversed += word[i];
        }

        Console.WriteLine("Reversed word = " + reversed);
    }
}