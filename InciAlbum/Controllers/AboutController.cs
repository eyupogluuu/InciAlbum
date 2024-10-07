using InciAlbum.BusinessLayer.Abstract;
using InciAlbum.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace InciAlbum.Controllers
{
    public class AboutController : Controller
    {
        private readonly IAboutService aboutService;

        public AboutController(IAboutService aboutService)
        {
            this.aboutService = aboutService;
        }

        public IActionResult Index()
        {
            var values = aboutService.GetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddAbout()
        {
            return View();

        }
        [HttpPost]
        public IActionResult AddAbout(About about)
        {
            aboutService.Insert(about);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteAbout(int id)
        {
            var sil = aboutService.GetById(id);
            aboutService.Delete(sil);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateAbout(int id)
        {
            var serv = aboutService.GetById(id);
            return View(serv);
        }
        [HttpPost]
        public IActionResult UpdateAbout(About about)
        {
            aboutService.Update(about);
            return RedirectToAction("Index");
        }
    }
}
