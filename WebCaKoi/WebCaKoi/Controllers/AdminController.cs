using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebCaKoi.Controllers
{
    public class AdminController : Controller
    {
        // GET: AdminController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AdminController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdminController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdminController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdminController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public IActionResult SomeAction()
        {
            // Kiểm tra xem trong claims của người dùng có claim nào với tên "IdKh" hoặc "Idnv"
            var isCustomer = User.Claims.FirstOrDefault(c => c.Type == "IdKh") != null;
            var isEmployee = User.Claims.FirstOrDefault(c => c.Type == "Idnv") != null;

            if (isCustomer)
            {
                // Xử lý cho khách hàng
                return View("Index", "Home"); // Ví dụ trả về một view riêng cho khách hàng
            }
            else if (isEmployee)
            {
                // Xử lý cho nhân viên
                return View("Index", "NhanVien"); // Ví dụ trả về một view riêng cho nhân viên
            }
            else
            {
                // Nếu không phải khách hàng hay nhân viên
                return Unauthorized(); // Hoặc chuyển hướng đến trang đăng nhập hoặc lỗi
            }
        }
    }
}
