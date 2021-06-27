using BooksApi;
using BooksApi.Services;
using MongoDB.Driver;
using System.Linq;
using System;
using System.Collections.Generic;
using Moq;

namespace BooksApiTest
{
    public class BookServiceMock : IBookService
    {
        public readonly List<Book> _books;

        public BookServiceMock()
        {
            _books = new List<Book>()
            {
                new Book()
                {
                    Id = "60d4f3d706508ecef45e6090",
                    BookName = "Design Patterns",
                    Price = Convert.ToDecimal("54.93"),
                    Category = "Computers",
                    Author = "Ralph Jonhson"
                },
                new Book()
                {
                    Id = "60d4f3d706508ecef45e6091",
                    BookName = "Clean Code",
                    Price = Convert.ToDecimal("43.15"),
                    Category = "Computers",
                    Author = "Robert C. Martin"
                }
            };

        }

        public Book Create(Book book)
        {
            var mockMongoCollection = new Mock<IMongoCollection<Book>>();
            mockMongoCollection.Object.InsertOne(book);
 
            return book;
        }

        public List<Book> Get()
        {
            //var mockMongoCollection = new Mock<IMongoCollection<Book>>();
            //return mockMongoCollection.Object.Find(book => true).ToList();
            return _books.ToList();

        }

        public Book Get(string id)
        {
            return _books.Find(book => book.Id == id);

        }

        public void Remove(Book book)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(string id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(string id, Book book)
        {
            throw new System.NotImplementedException();
        }
    }
}
