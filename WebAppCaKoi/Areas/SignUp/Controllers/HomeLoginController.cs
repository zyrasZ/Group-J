using CaKoi.Respositories.Entities;
using CaKoi.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace WebAppCaKoi.Areas.SignUp.Controllers
{
    [Area("SignUp")]
    public class HomeLoginController : Controller
    {
        public readonly IKhachHangService _service;
        public HomeLoginController(IKhachHangService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            var tenTaiKhoan = HttpContext.Session.GetString("TenTaiKhoan");
            ViewBag.TenTaiKhoan = tenTaiKhoan ?? "Khách"; // Hoặc một giá trị mặc định
            return View();
        }
        [HttpPost]
        public IActionResult Index(string TenTaiKhoan, string MatKhau)
        {
            // Tìm khách hàng từ cơ sở dữ liệu theo tên tài khoản
            var khach = _service.GetKhachHangByTenTaiKhoan(TenTaiKhoan);

            // Kiểm tra nếu khách hàng tồn tại và mật khẩu khớp
            if (khach != null && khach.MatKhau == MatKhau)
            {
                // Lưu thông tin người dùng vào session
                HttpContext.Session.SetString("TenTaiKhoan", khach.TenTaiKhoan);
                HttpContext.Session.SetInt32("KhachHangId", khach.Idkh);

                // Chuyển hướng về trang chính hoặc dashboard sau khi đăng nhập thành công
                return RedirectToAction("Index", "Home", new { area = "" });
            }

            // Nếu sai thông tin, trả về thông báo lỗi
            ViewBag.ErrorMessage = "Tên tài khoản hoặc mật khẩu không chính xác.";
            return View();
        }
    }
}
