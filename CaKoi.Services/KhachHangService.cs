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

        public KhachHang GetKhachHangByTenTaiKhoan(string tenTaiKhoan)
        {
            return _respository.GetKhachHangByTenTaiKhoan(tenTaiKhoan);
        }

        public Task<List<KhachHang>> GetKhachHangs()
        {
            return _respository.GetKhachHangs();
        }
    }
}
