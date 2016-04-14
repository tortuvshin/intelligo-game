using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Itera.Fagdag.November.Domain.Models;

namespace Itera.Fagdag.November.Repositories.Contracts
{
    public interface ICartRepository
    {
        void InsertCart(Cart cart);
        Cart GetCart(int id);
        Cart GetCartByUserId(string userId);
        void UpdateCart(Cart cart);
    }
}
