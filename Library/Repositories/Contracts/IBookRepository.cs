using Itera.Fagdag.November.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itera.Fagdag.November.Repositories.Contracts
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetBooks();
        Book GetBook(int id);
        void Update(Book book);
        void Remove(Book book);
        void Add(Book book);
    }
}
