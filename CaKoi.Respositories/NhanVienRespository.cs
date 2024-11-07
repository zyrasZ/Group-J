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
    public class NhanVienRespository : INhanVienRespository
    {
        public readonly CaKoiContext _context;
        public NhanVienRespository(CaKoiContext context)
        {
            _context = context;
        }
        public NhanVien GetEmployeeByUandP(string username, string password)
        {
            return _context.NhanViens.FirstOrDefault(user => user.TenTaiKhoan == username && user.MatKhau == password);
        }
    }
}
