using BooksApi;
using BooksApi.Controllers;
using BooksApi.Services;
using Microsoft.AspNetCore.Mvc;
using Xunit;
using System;
using System.Collections.Generic;
using Moq;

namespace TestProjectBooksApi.Controllers
{
    public class BooksControllerTest : ControllerBase
    {
        public readonly BooksController _booksController;

        public BooksControllerTest(BooksController booksController)
        {
            _booksController = booksController;

        }

        [Fact]
        public void Get_WhenCalled_ReturnsOkResult()
        {

            var okResult = _booksController.Get();

            Assert.NotNull(okResult);

            Assert.IsType<OkObjectResult>(okResult.Result);

        }

        [Fact]
        public void Get_WhenCalled_ReturnsAllItems()
        {
            //var okResult = _booksController.Get().Result as OkObjectResult;
            // Assert
            //var items = Assert.IsType<List<Book>>(okResult.Value);
            //Assert.Equal(2, items.Count);
        }



        private List<Book> GetTestBooks()
        {
            var books = new List<Book>();
            books.Add(new Book()
            {
                Id = "60d4f3d706508ecef45e6090",
                BookName = "Design Patterns",
                Price = Convert.ToDecimal("54.93"),
                Category = "Computers",
                Author = "Ralph Johnson"
            });
            books.Add(new Book()
            {
                Id = "60d4f3d706508ecef45e6091",
                BookName = "Clean Code",
                Price = Convert.ToDecimal("43.15"),
                Category = "Computers",
                Author = "Robert C. Martin"
            });
            return books;
        }
    }
}
