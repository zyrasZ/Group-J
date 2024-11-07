using CaKoi.Respositories.Entities;
using CaKoi.Respositories.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaKoi.Respositories
{
    public class KhachHangRespository : IKhachHangRespository
    {
        public readonly CaKoiContext _context;
        public KhachHangRespository(CaKoiContext context) {
            _context = context;
        }

        public bool AddKhachHang(KhachHang model)
        {
            _context.KhachHangs.Add(model);
            _context.SaveChanges();
            return true;
        }

<<<<<<< HEAD
       

        public KhachHang GetKhachByID(int id)
        {
            return _context.KhachHangs.FirstOrDefault(x => x.Idkh == id);
        }

=======
>>>>>>> cf7a9847859f73a1fb7551d65a287d0e7c781ced
        public KhachHang GetKhachHangByTenTaiKhoan(string tenTaiKhoan)
        {
            return _context.KhachHangs.FirstOrDefault(kh => kh.TenTaiKhoan == tenTaiKhoan);
        }

        public async Task<List<KhachHang>> GetKhachHangs()
        {
            return await _context.KhachHangs.ToListAsync();
        }
<<<<<<< HEAD

        public KhachHang GetUserByUsernameAndPassword(string username, string password)
        {
            return _context.KhachHangs.FirstOrDefault(user => user.TenTaiKhoan == username && user.MatKhau == password);
        }
=======
>>>>>>> cf7a9847859f73a1fb7551d65a287d0e7c781ced
    }
}
