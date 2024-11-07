<<<<<<< HEAD
﻿using CaKoi.Respositories.Entities;
using CaKoi.Services.Interface;
using Microsoft.AspNetCore.Authorization;
=======
﻿using CaKoi.Services.Interface;
>>>>>>> cf7a9847859f73a1fb7551d65a287d0e7c781ced
using Microsoft.AspNetCore.Mvc;

namespace WebAppCaKoi.Controllers
{
<<<<<<< HEAD
    
    public class ShopController : Controller
    {
        
        private readonly ICaCoiService _service;
        private readonly IDonHangService _DHservice;
        public ShopController(ICaCoiService service, IDonHangService DHservice)
        {
            _service = service;
            _DHservice = DHservice;
=======
    public class ShopController : Controller
    {
        private readonly ICaCoiService _service;
        public ShopController(ICaCoiService service)
        {
            _service = service;
>>>>>>> cf7a9847859f73a1fb7551d65a287d0e7c781ced
        }
        public async Task<IActionResult> Index()
        {
            var ca = await _service.GetCaCois();
            return View(ca);
        }
<<<<<<< HEAD
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
            _DHservice.AddDonHang(model);
            return RedirectToAction("DonHang", "Page");
        }
=======
>>>>>>> cf7a9847859f73a1fb7551d65a287d0e7c781ced
    }
}
