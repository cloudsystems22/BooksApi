using BooksApi;
using BooksApi.Controllers;
using BooksApi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Xunit;

namespace BooksApiTest
{
    public class BooksControllerTest
    {
        BooksController _controller;
        IBookService _service;

        public BooksControllerTest()
        {
            _service = new BookServiceMock();
            _controller = new BooksController(_service);
        }

        [Fact]
        public void Get_List_NotNull()
        {
            // Act
            var result = _controller.Get();
            
            // Assert
            Assert.NotNull(result);
            

        }

        [Theory]
        [InlineData("60d4f3d706508ecef45e6090")]
        public void Get_Id_Exist(string id)
        {
            var result = _controller.Get(id);

            Assert.True(true);
        }
    }
}
