using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Itera.Fagdag.November.Domain.Models;

namespace Itera.Fagdag.November.ViewModels
{
    public class CartViewModel
    {
        public ICollection<CartBook> CartBooks { get; set; }

        public string CartText
        {
            get
            {
                if (CartBooks.Count == 0)
                {
                    return "Цуглуулга хоосон байна.";
                }
                return string.Empty;
            }
        }
    }
}