using CaKoi.Respositories.Entities;
using CaKoi.Respositories.Interface;
using CaKoi.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaKoi.Services
{
    public class NhanVienService : INhanVienService
    {
        private readonly INhanVienRespository _respository;
        public NhanVienService(INhanVienRespository respository)
        {
            _respository = respository;
        }
        public NhanVien Loginn(string username, string password)
        {
            return _respository.GetEmployeeByUandP(username, password);
        }
    }
}
