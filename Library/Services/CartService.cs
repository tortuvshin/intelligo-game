using Itera.Fagdag.November.Domain.Models;
using Itera.Fagdag.November.Repositories.Contracts;
using Itera.Fagdag.November.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Itera.Fagdag.November.Services
{
    public class CartService : ICartService
    {
        private readonly ICartRepository _cartRepository;
        
        public CartService(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }

        public void InsertCart(Cart cart)
        {
            _cartRepository.InsertCart(cart);
        }

        public Cart GetCart(int id)
        {
            return _cartRepository.GetCart(id);
        }
        public Cart GetCartByUserId(string userId)
        {
            return _cartRepository.GetCartByUserId(userId);
        }

        public void UpdateCart(Cart cart)
        {
            _cartRepository.UpdateCart(cart);
        }
    }
}