using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Mapping;
using System.Linq;
using System.Web.Mvc;
using AutoMapper;
using Itera.Fagdag.November.Domain.Models;
using Itera.Fagdag.November.Services.Contracts;
using Itera.Fagdag.November.Validation.Contracts;
using Itera.Fagdag.November.ViewModels;
using Microsoft.AspNet.Identity;

namespace Itera.Fagdag.November.Controllers
{
    [Authorize]
    public class CartController : Common
    {
        private readonly IBookService _bookService;
        private readonly ICartService _cartService;
        private readonly IBookValidation _bookValidation;

        public CartController(IBookService bookService, ICartService cartService, IBookValidation bookValidation)
        {
            _bookService = bookService;
            _cartService = cartService;
            _bookValidation = bookValidation;
        }

        public ActionResult Index()
        {
            var userId = GetUserId();
            var cart = _cartService.GetCartByUserId(userId) ?? CreateNewEmptyCart(userId);
            var cartViewModel = Mapper.Map<Cart, CartViewModel>(cart);
            return View("Details", cartViewModel);
        }

        private static Cart CreateNewEmptyCart(string userId)
        {
            return new Cart()
            {
                UserId = userId,
                CartBooks = new Collection<CartBook>()
            };
        }

        public ActionResult UnreserveAndUpdateCart(int id)
        {
            var userId = GetUserId();
            var cart = _cartService.GetCartByUserId(userId);

            if (cart == null)
            {
                return View("~/Views/Common/NotFound.cshtml", new NotFoundViewModel() {ElementName = "User cart"});
            }

            var cartBook = cart.CartBooks.FirstOrDefault(x => x.Id == id);

            if (cartBook != null)
            {
                var book = Mapper.Map<CartBook, Book>(cartBook);

                if (!_bookValidation.BookIsAlreadyUnreserved(book))
                {
                    Unreserve(book);
                    RemoveBookFromCart(cart, cartBook);
                }
            }
            var cartViewModel = Mapper.Map<Cart, CartViewModel>(cart);
            return View("Details", cartViewModel);
        }

        private void Unreserve(Book book)
        {
            book.ReservedBy = null;
            _bookService.Update(book);
        }

        private void RemoveBookFromCart(Cart cart, CartBook cartBook)
        {
            cart.CartBooks.Remove(cartBook);
            _cartService.UpdateCart(cart);
        }

        public ActionResult ReserveAndUpdateCart(int id)
        {
            var userId = GetUserId();
            var cart = _cartService.GetCartByUserId(userId);
            var book = _bookService.GetBook(id);

            if (book != null)
            {
                if (!_bookValidation.BookIsAlreadyReserved(book))
                {
                    Reserve(book);
                    var cartBook = Mapper.Map<Book, CartBook>(book);

                    if (cart == null)
                    {
                        cart = CreateNewCartWithBook(userId, cartBook);
                    }
                    else
                    {
                        AddNewBookToCart(cart, cartBook);
                    }
                }
            }

            var cartViewModel = Mapper.Map<Cart, CartViewModel>(cart);

            return View("Details", cartViewModel);
        }

        private void Reserve(Book book)
        {
            book.ReservedBy = GetUserName();
            _bookService.Update(book);
        }

        private void AddNewBookToCart(Cart cart, CartBook cartBook)
        {
            if (cart.CartBooks.FirstOrDefault(x => x.BookId == cartBook.BookId) == null)
            {
                cart.CartBooks.Add(cartBook);
                _cartService.UpdateCart(cart);
            }
        }

        private Cart CreateNewCartWithBook(string userId, CartBook cartBook)
        {
            var newCart = new Cart()
            {
                UserId = userId,
                CartBooks = new Collection<CartBook>()
                {
                    cartBook
                }
            };
            _cartService.InsertCart(newCart);
            return newCart;
        }
    }
}