using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using Itera.Fagdag.November.Data;
using Itera.Fagdag.November.Domain.Models;
using Itera.Fagdag.November.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Itera.Fagdag.November.Repositories
{
    public class CartRepository : ICartRepository
    {
        private readonly IteraLibraryDbContext _dbContext;

        public CartRepository(IteraLibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void InsertCart(Cart cart)
        {
            _dbContext.Carts.Add(cart);
            Save();
        }
        public Cart GetCart(int id)
        {
            return _dbContext.Carts.Find(id);
        }
        public Cart GetCartByUserId(string userId)
        {
            return _dbContext.Carts.FirstOrDefault(x => x.UserId == userId);
        }
        public void UpdateCart(Cart cart)
        {
            _dbContext.Entry(cart).State = EntityState.Modified;
            Save();
        }
        private void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}