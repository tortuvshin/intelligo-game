using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Itera.Fagdag.November.Domain.Models;
using Itera.Fagdag.November.Helpers;
using Itera.Fagdag.November.Logging.Contract;
using Itera.Fagdag.November.Resources.Keys;
using Itera.Fagdag.November.Services.Contracts;
using Itera.Fagdag.November.Validation.Contracts;
using Itera.Fagdag.November.ViewModels;
using OfficeOpenXml;

namespace Itera.Fagdag.November.Controllers
{
    [Authorize]
    public class ManageBooksController : Common
    {
        private readonly ILogger _logger;
        private readonly IBookService _bookService;
        private readonly IFileFormatValidation _fileFormatValidation;

        public ManageBooksController(ILogger logger, IBookService bookService,
            IFileFormatValidation fileFormatValidation)
        {
            _logger = logger;
            _bookService = bookService;
            _fileFormatValidation = fileFormatValidation;
        }

        public ActionResult Index()
        {
            var books = _bookService.GetBooks();
            if (books == null)
            {
                return View("~/Views/Common/NotFound.cshtml", new NotFoundViewModel() {ElementName = "Books"});
            }
            var bookViewModels = books.Select(Mapper.Map<Book, BookViewModel>).ToList();
            return View(bookViewModels);
        }

        public ActionResult Add()
        {
            return View();
        }

        public ActionResult AddMany()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddBooks(ManageBooksViewModel manageBooksViewModel)
        {
            if (manageBooksViewModel == null)
            {
                return View("~/Views/Common/NotFound.cshtml", new NotFoundViewModel() {ElementName = "Books"});
            }

            if (ModelState.IsValid)
            {
                ReadExcelSchemaAndCreateBooks(manageBooksViewModel);
                if (ModelState.Values.Any(x => x.Errors.Count >= 1))
                {
                    return View("AddMany", manageBooksViewModel);
                }
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Please upload an Excel file with book information.");
                return View("AddMany", manageBooksViewModel);
            }
            return RedirectToAction("index");
        }

        private void ReadExcelSchemaAndCreateBooks(ManageBooksViewModel manageBooksViewModel)
        {
            try
            {
                var fileName = manageBooksViewModel.ExcelSchemaBase.FileName;
                if (_fileFormatValidation.IsExcelType(fileName))
                {
                    var filePath = SaveOnServer(manageBooksViewModel.ExcelSchemaBase.FileName, Keys.ExcelSchemaBase);
                    var excelSchema = new FileInfo(filePath);
                    var datafile = new ExcelPackage(excelSchema);
                    var workbook = datafile.Workbook;
                    var workSheet = workbook.Worksheets.First();
                    const int startRowIndex = 2;
                    for (var rowIndex = startRowIndex; rowIndex <= workSheet.Dimension.End.Row; rowIndex++)
                    {
                        var book = ExtractValuesFromWorksheetAndCreateBook(workSheet, rowIndex);
                        if (book != null)
                        {
                            _bookService.Add(book);
                        }
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Please upload a valid Excel document.");
                }
            }
            catch (Exception e)
            {
                ModelState.AddModelError(string.Empty, "Something was wrong with the upload, please make sure the Excel template is correctly defined.");
                _logger.Error(e);
            }
        }

        private static Book ExtractValuesFromWorksheetAndCreateBook(ExcelWorksheet workSheet, int rowIndex)
        {
            var propertyDictionary = new Dictionary<string, string>();

            try
            {
                propertyDictionary["title"] = workSheet.Cells[rowIndex, 1].Value.ToString();
                propertyDictionary["author"] = workSheet.Cells[rowIndex, 2].Value.ToString();
                propertyDictionary["description"] = workSheet.Cells[rowIndex, 3].Value.ToString();
                propertyDictionary["language"] = workSheet.Cells[rowIndex, 4].Value.ToString();
                propertyDictionary["pages"] = workSheet.Cells[rowIndex, 5].Value.ToString();
                propertyDictionary["isbn10"] = workSheet.Cells[rowIndex, 6].Value.ToString();
                propertyDictionary["isbn13"] = workSheet.Cells[rowIndex, 7].Value.ToString();
            }
            catch (Exception)
            {
                return null;
            }

            var book = new Book()
            {
                Title = propertyDictionary["title"],
                Author = propertyDictionary["author"],
                Description = propertyDictionary["description"],
                Language = propertyDictionary["language"],
                Pages = propertyDictionary["pages"].ToInt32(),
                ISBN10 = propertyDictionary["isbn10"],
                ISBN13 = propertyDictionary["isbn13"],
                CoverImageUrl = Keys.PathNAImage
            };
            return book;
        }
        public ActionResult RemoveBook(int id)
        {
            var book = _bookService.GetBook(id);
            if (book == null)
            {
                return View("~/Views/Common/NotFound.cshtml", new NotFoundViewModel() { ElementName = "Book" });
            }
            _bookService.Remove(book);
            return RedirectToAction("Index", "ManageBooks");
        }

        [HttpPost]
        public ActionResult AddBook(BookViewModel bookViewModel)
        {
            if (bookViewModel == null)
            {
                return View("~/Views/Common/NotFound.cshtml", new NotFoundViewModel() {ElementName = "Book"});
            }

            if (ModelState.IsValid)
            {
                var book = Mapper.Map<BookViewModel, Book>(bookViewModel);
                SaveCoverImageOnServer(bookViewModel, book);
                if (ModelState.Values.Any(x => x.Errors.Count >= 1))
                {
                    return View("Add", bookViewModel);
                }
                _bookService.Add(book);
            }
            else
            {
                ModelState.AddModelError(string.Empty, "The fields below must be filled.");
                return View("Add", bookViewModel);
            }

            return RedirectToAction("index");
        }

        private void SaveCoverImageOnServer(BookViewModel bookViewModel, Book book)
        {
            var fileName = bookViewModel.CoverImageBase.FileName;
            if (_fileFormatValidation.IsImageType(fileName))
            {
                SaveOnServer(bookViewModel.CoverImageBase.FileName, Keys.CoverImageBase);
                book.CoverImageUrl = String.Concat(Keys.PathUploads + "/", bookViewModel.CoverImageBase.FileName);
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Please upload a valid image file.");
            }
        }

        [HttpPost]
        public ActionResult UpdateBook(string id)
        {
            var book = _bookService.GetBook(id.ToInt32());
            if (book == null)
            {
                return View("~/Views/Common/NotFound.cshtml", new NotFoundViewModel() { ElementName = "Book" });
            }

            SaveCoverImageOnServer(book);
            _bookService.Update(book);

            return RedirectToAction("Index");
        }

        private void SaveCoverImageOnServer(Book book)
        {
            foreach (var file in from string item in Request.Files select Request.Files[item])
            {
                SaveOnServer(file.FileName, Keys.CoverImageBase);
                book.CoverImageUrl = String.Concat(Keys.PathUploads + "/", file.FileName);
                break;
            }
        }
    }
}