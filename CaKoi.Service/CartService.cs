using CaKoi.Respository;
using CaKoi.Respository.Entities;
using CaKoi.Respository.Interface;
using CaKoi.Service.Interface;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
namespace CaKoi.Service
{
    public class CartService : ICartService
    {
        private readonly ICartRespository _cartRepository;
        private readonly ICaCoiRespository _caKoiRepository; // Nếu bạn cần truy cập thông tin Ca Koi
        private IKhachHangRespository _khachRespository;
        private IDonHangRespository _dhRespository;
        public CartService(ICartRespository cartRepository, ICaCoiRespository caKoiRepository, IKhachHangRespository khachRespository, IDonHangRespository dhRespository)
        {
            _cartRepository = cartRepository;
            _caKoiRepository = caKoiRepository;
            _khachRespository = khachRespository;
            _dhRespository = dhRespository;
        }

        public void AddToCart(int idkh, int idca, int quantity)
        {
            var khach =  _khachRespository.GetKhachByID(idkh);
            if (khach == null)
            {
                throw new InvalidOperationException("Khách hàng không tồn tại.");
            }

            var caKoi =  _caKoiRepository.GetItemByCaKoiId(idca);
            if (caKoi == null)
            {
                throw new InvalidOperationException("Cá koi không tồn tại.");
            }
            if (caKoi != null)
            {
                var donHangChiTiet = new DonHangChiTiet
                {
                    Idkh = khach.Idkh,
                    IdcaKoi = caKoi.IdcaKoi,
                    SoLuong = quantity,
                    Gia = caKoi.Gia,
                    TenLoai = caKoi.TenLoai,
                    TongTien = caKoi.Gia * quantity
                };
                // Kiểm tra nếu đối tượng này đã tồn tại trong giỏ hàng
                var existingItem =  _cartRepository.GetItemByCaKoiId(khach.Idkh, caKoi.IdcaKoi);
                if (existingItem != null)
                {
                    // Nếu đã tồn tại, có thể cập nhật số lượng
                    existingItem.SoLuong += quantity;
                    existingItem.TongTien = existingItem.SoLuong * existingItem.Gia;
                   _cartRepository.UpdateCartItem(existingItem);
                }
                else
                {
                    // Nếu chưa tồn tại, thêm mới
                   _cartRepository.AddToCart(donHangChiTiet);
                }
            }
        }
        public void Deletecart(int id)
        {
            _cartRepository.Deletecart(id);
            
        }
        public IEnumerable<DonHangChiTiet> GetCartItems()
        {
            return _cartRepository.GetCartItems();
        }

        public decimal GetTotalCT(int id)
        {
            return _cartRepository.GetTotalCT(id);
        }

        public decimal GetTotal(int value)
        {
            return _cartRepository.GetTotal(value);
        }
    }
}
