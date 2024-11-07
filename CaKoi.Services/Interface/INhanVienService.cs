using CaKoi.Respositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaKoi.Services.Interface
{
    public interface INhanVienService
    {
        NhanVien Loginn(string username, string password);
    }
}

