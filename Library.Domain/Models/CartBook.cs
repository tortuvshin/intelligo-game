using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Itera.Fagdag.November.Domain.Models
{
    public class CartBook
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string CoverImageUrl { get; set; }
        public int Pages { get; set; }
        public string ReservedBy { get; set; }
        public string Language { get; set; }
        public string ISBN10 { get; set; }
        public string ISBN13 { get; set; }
    }
}