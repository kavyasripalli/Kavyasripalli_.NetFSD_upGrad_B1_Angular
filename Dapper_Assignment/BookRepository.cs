using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using System.Data;

namespace Dapper_Assignment
{
    public class BookRepository
    {
        private readonly IDbConnection _db;

        public BookRepository()
        {
            _db = DbConnection.GetConnection();
        }

        // a. AddBook
        public void AddBook(Book book)
        {
            string query = "INSERT INTO Books (Title, Price, Author, Publisher, Language, PublishDate) VALUES (@Title, @Price, @Author, @Publisher, @Language, @PublishDate)";
            _db.Execute(query, book);
        }

        // b. EditBook
        public void EditBook(Book book)
        {
            string query = "UPDATE Books SET Price=@Price, Author=@Author WHERE BookId=@BookId";
            _db.Execute(query, book);
        }

        // c. DeleteBook
        public void DeleteBook(int id)
        {
            string query = "DELETE FROM Books WHERE BookId=@Id";
            _db.Execute(query, new { Id = id });
        }

        // d. GetBook by name
        public Book GetBookByName(string name)
        {
            return _db.QueryFirstOrDefault<Book>("SELECT * FROM Books WHERE Title=@Title", new { Title = name });
        }

        // e. GetBook by id
        public Book GetBookById(int id)
        {
            return _db.QueryFirstOrDefault<Book>("SELECT * FROM Books WHERE BookId=@Id", new { Id = id });
        }

        // f. GetAllBooks
        public List<Book> GetAllBooks()
        {
            return _db.Query<Book>("SELECT * FROM Books").ToList();
        }

        // g. GetAllBooksByAuthor
        public List<Book> GetAllBooksByAuthor(string author)
        {
            return _db.Query<Book>("SELECT * FROM Books WHERE Author=@Author", new { Author = author }).ToList();
        }

        // h. GetAllBooksByLang + Publisher
        public List<Book> GetAllBooksByLang(string lang)
        {
            return _db.Query<Book>("SELECT * FROM Books WHERE Language=@Lang", new { Lang = lang }).ToList();
        }

        public List<Book> GetAllBooksByPublisher(string publisher)
        {
            return _db.Query<Book>("SELECT * FROM Books WHERE Publisher=@Publisher", new { Publisher = publisher }).ToList();
        }
    }
}
