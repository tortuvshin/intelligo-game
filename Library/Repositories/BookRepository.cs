using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using Itera.Fagdag.November.Data;
using Itera.Fagdag.November.Domain.Models;
using Itera.Fagdag.November.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Itera.Fagdag.November.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly IteraLibraryDbContext _dbContext;

        public BookRepository(IteraLibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Book> GetBooks()
        {
            return _dbContext.Books.ToList();
        }

        public Book GetBook(int id)
        {
            return _dbContext.Books.Find(id);
        }
        public void Update(Book book)
        {
            _dbContext.Entry(book).State = EntityState.Modified;
            Save();
        }

        public void Remove(Book book)
        {
            _dbContext.Books.Remove(book);
            Save();
        }

        public void Add(Book book)
        {
            _dbContext.Books.Add(book);
            Save();
        }

        private void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}