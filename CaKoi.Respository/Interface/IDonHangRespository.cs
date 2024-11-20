﻿using CaKoi.Respository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CaKoi.Respository.Interface
{
    public interface IDonHangRespository
    {
        Boolean AddDonHang(DonHang model);
        Boolean AddDCT(DonCt model);
        Task<List<DonHang>> GetDonHangs();
        Task<List<DonHang>> GetDonHangs(int userid);
        Task <bool> EditDonHang(int id, DateOnly ngaygiao, string trangthai);
        Task<bool> AdminEditDonHang(int id , string choduyet);
        Task<bool> DeleteDonHang(int id);
        Task<bool> DeleteDCT(int idkh);
        Task<List<DonHangChiTiet>>? GetDonHangChiTiets(int id);
        Task<List<DonCt>>? GetChiTiets(int id);
        Task<List<DonHangChiTiet>> GetDonHangChiTiets();

    }
}
