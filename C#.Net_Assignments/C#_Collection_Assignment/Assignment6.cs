using System;
using System.Collections.Generic;
using System.Linq;

class Song
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Artist { get; set; }
}

class Assignment6
{
    public static void Run()
    {
        LinkedList<Song> playlist = new LinkedList<Song>();

        // add beginning
        var s1 = new Song { Id = 1, Title = "Song1", Artist = "A" };
        playlist.AddFirst(s1);

        // add end
        var s2 = new Song { Id = 2, Title = "Song2", Artist = "B" };
        playlist.AddLast(s2);

        // add middle (after s1)
        var s3 = new Song { Id = 3, Title = "Song3", Artist = "C" };
        playlist.AddAfter(playlist.Find(s1), s3);

        var s4 = new Song { Id = 4, Title = "Song4", Artist = "D" };
        playlist.AddLast(s4);

        Console.WriteLine("Forward:");
        foreach (var s in playlist)
            Console.WriteLine($"{s.Title} - {s.Artist}");

        Console.WriteLine("\nBackward:");
        var node = playlist.Last;
        while (node != null)
        {
            Console.WriteLine($"{node.Value.Title} - {node.Value.Artist}");
            node = node.Previous;
        }

        // remove specific song
        playlist.Remove(s3);

        Console.WriteLine("\nAfter Removing Song3:");
        foreach (var s in playlist)
            Console.WriteLine(s.Title);

        // find by title
        Console.WriteLine("\nFind Song2:");
        var found = playlist.FirstOrDefault(s => s.Title == "Song2");
        if (found != null)
            Console.WriteLine(found.Title + " found");

        // bonus - play next
        Console.WriteLine("\nPlay Next after Song1:");
        var current = playlist.Find(s1);
        if (current != null && current.Next != null)
            Console.WriteLine(current.Next.Value.Title);
    }
}