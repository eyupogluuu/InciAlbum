using Microsoft.AspNetCore.Mvc;

namespace InciAlbum.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult headPartial()
        {
            return PartialView();
        }
        public PartialViewResult headerPartial()
        {
            return PartialView();
        }
        public PartialViewResult sidebarPartial()
        {
            return PartialView();
        }
        public PartialViewResult footerPartial()
        {
            return PartialView();
        }
        public PartialViewResult scriptPartial()
        {
            return PartialView();
        }
    }
}
