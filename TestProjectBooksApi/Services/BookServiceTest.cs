using BooksApi;
using BooksApi.Controllers;
using BooksApi.Services;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace TestProjectBooksApi.Services
{
    public class BookServiceTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void RetornaListaBooksGet()
        {
            var bookService = new Mock<BookService>();
            
            Assert.Pass("Constrido com sucesso!");
        }
    }
}
