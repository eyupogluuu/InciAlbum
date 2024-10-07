using InciAlbum.BusinessLayer.Abstract;
using InciAlbum.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace InciAlbum.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdminService adminService;

        public AdminController(IAdminService adminService)
        {
            this.adminService = adminService;
        }

        public IActionResult Index()
        {
            var values = adminService.GetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddAdmin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAdmin(Admin admin)
        {
        
            adminService.Insert(admin);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteAdmin(int id)
        {
            var sil = adminService.GetById(id);
            adminService.Delete(sil);
            return RedirectToAction("Index");
        }
    }
}
