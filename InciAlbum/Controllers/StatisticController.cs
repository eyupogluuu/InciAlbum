using InciAlbum.DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace InciAlbum.Controllers
{
    public class StatisticController : Controller
    {
        InciAlbumContext db = new InciAlbumContext(); 
        public IActionResult Index()
        {
            var urunsay = db.Products.Count();
            ViewBag.urun = urunsay;

            var mesajsay = db.Contacts.Count();
            ViewBag.msg = mesajsay;

            var fotosay=db.Images.Count();
            ViewBag.ft = fotosay;

            var takimsay=db.Stuffs.Count();
            ViewBag.stuff=takimsay;

            return View();
        }
    }
}
