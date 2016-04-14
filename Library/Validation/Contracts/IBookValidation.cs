using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Itera.Fagdag.November.Domain.Models;

namespace Itera.Fagdag.November.Validation.Contracts
{
    public interface IBookValidation
    {
        bool BookIsAlreadyReserved(Book book);
        bool BookIsAlreadyUnreserved(Book book);
    }
}
