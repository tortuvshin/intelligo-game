using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;

namespace Lib.Models
{
    public class BookContext : DbContext
    {
        public BookContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<Books> Books { get; set; }
    }

}
