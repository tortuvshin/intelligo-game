using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Itera.Fagdag.November.Domain.Models;
using Itera.Fagdag.November.Logging.Contract;
using Itera.Fagdag.November.Services.Contracts;
using Itera.Fagdag.November.ViewModels;

namespace Itera.Fagdag.November.Controllers
{
    public class BookController : Common
    {
        private readonly IBookService _bookService;


        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        public ActionResult Index()
        {
            var books = _bookService.GetBooks();
            if (books == null)
            {
                return View("~/Views/Common/NotFound.cshtml", new NotFoundViewModel(){ElementName = "Books"});
            }
            var bookViewModels = books.Select(Mapper.Map<Book, BookViewModel>).ToList();
            return View(bookViewModels);
        }
        public ActionResult Details(int id)
        {
            var book = _bookService.GetBook(id);
            if (book == null)
            {
                return View("~/Views/Common/NotFound.cshtml", new NotFoundViewModel(){ElementName = "Book"});
            }
            var bookViewModel = Mapper.Map<Book, BookViewModel>(book);
            bookViewModel.LoggedInUserName = GetUserName();
            return View(bookViewModel);
        }
    }
}