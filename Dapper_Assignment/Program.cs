namespace Dapper_Assignment
{
    class Program
    {
        static void Main()
        {
            BookRepository repo = new BookRepository();

            while (true)
            {
                Console.WriteLine("\n1.Add 2.Edit 3.Delete 4.GetById 5.GetAll 6.ByAuthor 7.ByLang 8.Exit");
                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid choice!");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        var book = new Book();
                        Console.Write("Title: ");
                        book.Title = Console.ReadLine();
                        Console.Write("Price: ");
                        decimal price;
                        if (!decimal.TryParse(Console.ReadLine(), out price))
                        {
                            Console.WriteLine("Invalid price!");
                            break;
                        }
                        book.Price = price;
                        Console.Write("Author: ");
                        book.Author = Console.ReadLine();
                        Console.Write("Publisher: ");
                        book.Publisher = Console.ReadLine();
                        Console.Write("Language: ");
                        book.Language = Console.ReadLine();
                        book.PublishDate = DateTime.Now;

                        repo.AddBook(book);
                        Console.WriteLine("Added!");
                        break;

                    case 2:
                        Console.Write("BookId: ");
                        int editId;
                        if (!int.TryParse(Console.ReadLine(), out editId))
                        {
                            Console.WriteLine("Invalid ID!");
                            break;
                        }

                        var updateBook = new Book { BookId = editId };
                        Console.Write("New Price: ");
                        decimal newPrice;
                        if (!decimal.TryParse(Console.ReadLine(), out newPrice))
                        {
                            Console.WriteLine("Invalid price!");
                            break;
                        }
                        updateBook.Price = newPrice;
                        Console.Write("New Author: ");
                        updateBook.Author = Console.ReadLine();

                        repo.EditBook(updateBook);
                        Console.WriteLine("Updated!");
                        break;

                    case 3:
                        Console.Write("BookId: ");
                        repo.DeleteBook(int.Parse(Console.ReadLine()));
                        Console.WriteLine("Deleted!");
                        break;

                    case 4:
                        int getId;
                        Console.Write("Enter BookId: ");
                        if (!int.TryParse(Console.ReadLine(), out getId))
                        {
                            Console.WriteLine("Invalid ID!");
                            break;
                        }

                        var b = repo.GetBookById(getId);

                        if (b != null)
                            Console.WriteLine($"{b.Title} - {b.Author}");
                        else
                            Console.WriteLine("Book not found");

                        break;

                    case 5:
                        var all = repo.GetAllBooks();
                        foreach (var item in all)
                            Console.WriteLine($"{item.BookId} {item.Title}");
                        break;

                    case 6:
                        Console.Write("Enter Author Name: ");
                        string author = Console.ReadLine();

                        var byAuthor = repo.GetAllBooksByAuthor(author);

                        if (byAuthor.Count > 0)
                        {
                            foreach (var item in byAuthor)
                            {
                                Console.WriteLine($"{item.BookId} | {item.Title} | {item.Author}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No books found for this author.");
                        }
                        break;

                    case 7:
                        Console.Write("Enter Language: ");
                        string lang = Console.ReadLine();

                        var byLang = repo.GetAllBooksByLang(lang);

                        if (byLang.Count > 0)
                        {
                            foreach (var item in byLang)
                            {
                                Console.WriteLine($"{item.BookId} | {item.Title} | {item.Language}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No books found for this language.");
                        }
                        break;

                    case 8:
                        return;
                }
            }
        }
    }
}
