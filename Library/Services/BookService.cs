using Itera.Fagdag.November.Domain.Models;
using Itera.Fagdag.November.Repositories.Contracts;
using Itera.Fagdag.November.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Itera.Fagdag.November.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IEnumerable<Book> GetBooks()
        {
            return _bookRepository.GetBooks();
        }
        
        public Book GetBook(int id)
        {
            return _bookRepository.GetBook(id);
        }

        public void Update(Book book)
        {
            _bookRepository.Update(book);
        }

        public void Remove(Book book)
        {
            _bookRepository.Remove(book);
        }

        public void Add(Book book)
        {
            _bookRepository.Add(book);
        }
    }
}