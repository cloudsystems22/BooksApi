using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksApi.Services
{
    public interface IBookService
    {
        public List<Book> Get();

        public Book Get(string id);

        public Book Create(Book book);

        public void Update(string id, Book book);

        public void Remove(Book book);

        public void Remove(string id);

    }
}
