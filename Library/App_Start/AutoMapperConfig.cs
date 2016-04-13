using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Itera.Fagdag.November.Domain.Models;
using Itera.Fagdag.November.ViewModels;

namespace Itera.Fagdag.November.App_Start
{
    public static class AutoMapperConfig
    {
        public static void Configure()
        {
            Mapper.CreateMap<Book, BookViewModel>();
            Mapper.CreateMap<BookViewModel, Book>();
            Mapper.CreateMap<Cart, CartViewModel>();
            Mapper.CreateMap<Book, CartBook>();
            Mapper.CreateMap<CartBook, Book>();
        }
    }
}