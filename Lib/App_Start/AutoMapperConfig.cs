using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;

namespace Lib.App_Start
{
    public class AutoMapperConfig
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