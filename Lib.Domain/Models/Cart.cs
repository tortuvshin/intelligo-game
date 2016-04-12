using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lib.Domain.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public virtual ICollection<CartBook> CartBooks { get; set; }
    }
}