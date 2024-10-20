﻿using CaKoi.Respositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaKoi.Respositories.Interface
{
    public interface IKhachHangRespository
    {
        Task<List<KhachHang>> GetKhachHangs();
        Boolean AddKhachHang(KhachHang model);
        KhachHang GetKhachHangByTenTaiKhoan(string tenTaiKhoan);
    }
}
