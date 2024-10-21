using CaKoi.Respositories.Entities;
using CaKoi.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppCaKoi.Models;

namespace WebAppCaKoi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public readonly IKhachHangService _service;
        public HomeController(ILogger<HomeController> logger, IKhachHangService service)
        {
            _service = service;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(KhachHang model)
        {
            if (ModelState.IsValid)
            {
                _service.AddKhachHang(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
