using System;
using System.Collections.Generic;
using System.Linq;

class Assignment3
{
    public static void Run()
    {
        HashSet<string> emails = new HashSet<string>()
        {
            "a@gmail.com",
            "b@gmail.com",
            "c@gmail.com",
            "a@gmail.com",
            "d@gmail.com",
            "e@gmail.com",
            "b@gmail.com",
            "f@gmail.com",
            "g@gmail.com",
            "h@gmail.com"
        };

        Console.WriteLine("Unique Emails:");
        foreach (var e in emails)
            Console.WriteLine(e);

        Console.WriteLine("\nCheck email b@gmail.com:");
        Console.WriteLine(emails.Contains("b@gmail.com"));

        emails.Remove("c@gmail.com");

        Console.WriteLine("\nAfter removing c@gmail.com:");
        foreach (var e in emails)
            Console.WriteLine(e);

        // bonus
        HashSet<string> event2 = new HashSet<string>()
        {
            "x@gmail.com",
            "b@gmail.com",
            "g@gmail.com",
            "y@gmail.com"
        };

        Console.WriteLine("\nCommon Participants:");
        var common = emails.Intersect(event2);
        foreach (var e in common)
            Console.WriteLine(e);
    }
}