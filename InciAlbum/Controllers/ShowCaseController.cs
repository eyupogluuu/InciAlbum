using Microsoft.AspNetCore.Mvc;

namespace InciAlbum.Controllers
{
    public class ShowCaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
