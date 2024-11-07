using CaKoi.Respositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CaKoi.Respositories.Interface
{
    public interface IDonHangRespository
    {
        Boolean AddDonHang(DonHang model);
        Task<List<DonHang>> GetDonHangs();
        Task <bool> EditDonHang(int id, string trangthai);
        Task<bool> DeleteDonHang(int id);
        Task<List<DonHangChiTiet>> GetDonHangChiTiets(int id);
        Task<List<DonHangChiTiet>> GetDonHangChiTiets();
    }
}
