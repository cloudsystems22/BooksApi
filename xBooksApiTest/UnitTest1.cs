using BooksApi.Controllers;
using BooksApi.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using Xunit;

namespace xBooksApiTest
{
    public class UnitTest1
    {
        public readonly BooksController _booksController;

        public UnitTest1(BooksController booksController)
        {
            _booksController = booksController;

        }

        [Fact]
        public void Test1()
        {
            //var booksController = new Mock<BooksController>().Object;
            var okResult = _booksController.Get();

            Assert.NotNull(okResult);

            Assert.IsType<OkObjectResult>(okResult.Result);
        }
    }
}
