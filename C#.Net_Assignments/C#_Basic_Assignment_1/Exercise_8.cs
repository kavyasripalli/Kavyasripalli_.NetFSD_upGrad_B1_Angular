using System;

public class Exercise_8
{
    public static void Run()
    {
        string str;
        char ch;

        Console.Write("Enter a string: ");
        str = Console.ReadLine();

        if (str.Length < 3)
        {
            Console.WriteLine("String must have at least 3 characters");
        }
        else
        {
            ch = str[2];

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' ||
                ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine("3rd character is a Vowel: " + ch);
            }
            else
            {
                Console.WriteLine("3rd character is a Consonant: " + ch);
            }
        }
    }
}