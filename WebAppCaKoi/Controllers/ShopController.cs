using CaKoi.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace WebAppCaKoi.Controllers
{
    public class ShopController : Controller
    {
        private readonly ICaCoiService _service;
        public ShopController(ICaCoiService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var ca = await _service.GetCaCois();
            return View(ca);
        }
    }
}
