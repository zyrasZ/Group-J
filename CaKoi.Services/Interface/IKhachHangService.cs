using CaKoi.Respositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaKoi.Services.Interface
{
    public interface IKhachHangService
    {
        Task<List<KhachHang>> GetKhachHangs();
        Boolean AddKhachHang(KhachHang model);
        KhachHang GetKhachHangByTenTaiKhoan(string tenTaiKhoan);
<<<<<<< HEAD
        KhachHang Login(string username, string password);
        KhachHang GetKhachByID(int id);
=======
>>>>>>> cf7a9847859f73a1fb7551d65a287d0e7c781ced
    }
}
