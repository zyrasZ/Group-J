using CaKoi.Respositories.Entities;
using CaKoi.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaKoi.Respositories.Interface;
namespace CaKoi.Services
{
    public class KhachHangService : IKhachHangService
    {
        private readonly IKhachHangRespository _respository;
        public KhachHangService(IKhachHangRespository respository)
        {
            _respository = respository;
        }

        public bool AddKhachHang(KhachHang model)
        {
            _respository.AddKhachHang(model);
            return true;
        }

<<<<<<< HEAD
        public KhachHang GetKhachByID(int id)
        {
            return _respository.GetKhachByID(id);
        }

=======
>>>>>>> cf7a9847859f73a1fb7551d65a287d0e7c781ced
        public KhachHang GetKhachHangByTenTaiKhoan(string tenTaiKhoan)
        {
            return _respository.GetKhachHangByTenTaiKhoan(tenTaiKhoan);
        }

        public Task<List<KhachHang>> GetKhachHangs()
        {
            return _respository.GetKhachHangs();
        }
<<<<<<< HEAD

        public KhachHang Login(string username, string password)
        {
            return _respository.GetUserByUsernameAndPassword(username, password);
        }

        
=======
>>>>>>> cf7a9847859f73a1fb7551d65a287d0e7c781ced
    }
}
