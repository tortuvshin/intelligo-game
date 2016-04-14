using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Itera.Fagdag.November.Domain.Models;
using Itera.Fagdag.November.Validation.Contracts;

namespace Itera.Fagdag.November.Validation
{
    public class BookValidation : IBookValidation
    {
        public bool BookIsAlreadyReserved(Book book)
        {
            if (!string.IsNullOrEmpty(book.ReservedBy)) {
                return true;
            }
            return false;
        }

        public bool BookIsAlreadyUnreserved(Book book)
        {
            if (string.IsNullOrEmpty(book.ReservedBy)) {
                return true;
            }
            return false;
        }
    }
}