using BooksApi;
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
        public void Get()
        {
            var bookService = new Mock<BookService>();
            bookService.Setup(s => s.Get()).Verifiable();

            Assert.Pass("");
        }
    }
}
