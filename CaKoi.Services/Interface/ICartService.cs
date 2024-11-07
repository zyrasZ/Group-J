using CaKoi.Respositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaKoi.Services.Interface
{
    public interface ICartService
    {
        void AddToCart(int idkh, int id, int quantity);
        IEnumerable<DonHangChiTiet> GetCartItems();
        void Deletecart(int id);
        decimal GetTotal();
    }
}
