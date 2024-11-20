
using CaKoi.Respository.Entities;
using CaKoi.Service;
using CaKoi.Service.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebCaKoi.Controllers
{

    public class ShopController : Controller
    {

        private readonly ICaCoiService _service;
        private readonly IDonHangService _DHservice;
        private readonly ICartService _cartService;
        public ShopController(ICaCoiService service, IDonHangService DHservice, ICartService cartService)
        {
            _service = service;
            _DHservice = DHservice;
            _cartService = cartService;
        }

        public async Task<IActionResult> Index()
        {
            var ca = await _service.GetCaCois();
            return View(ca);
        }
        public IActionResult DonHang()
        {
            var UserID = HttpContext.Session.GetInt32("IdKh");
            var model = new DonHang
            {
                Idkh = UserID,
                TrangThai = "chua",
                ChoDuyet = "chua"
            }; // Gán vào ViewModel
            return View(model);
        }
        [HttpPost]
        public IActionResult DonHang(DonHang model)
        {
            var userId = HttpContext.Session.GetInt32("IdKh");

            // tìm danh sách đơn hàng
            var cartItems = _cartService.GetCartItems()
                .Where(item => item.Idkh == userId)
                .ToList();

            // chuyển dữ liệu sang DonCt
            foreach (var item in cartItems)
            {
                var donCt = new DonCt
                {
                    Idkh = item.Idkh,
                    IdcaKoi = item.IdcaKoi,
                    TenLoai = item.TenLoai,
                    SoLuong = item.SoLuong,
                    Gia = item.Gia,
                    TongTien = item.TongTien
                };

                // lưu vào csdl
                _DHservice.AddDCT(donCt);
            }

            _DHservice.AddDonHang(model);
            return RedirectToAction("DonHang", "Page");
        }

        public async Task<IActionResult> Search(string searchQuery)
        {
            var products = await _service.SearchProductsAsync(searchQuery);
            return View("Index", products);
        }
    }
}
