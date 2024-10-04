using InciAlbum.BusinessLayer.Abstract;
using InciAlbum.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace InciAlbum.Controllers
{
    public class myAdressController : Controller
    {
        private readonly ImyAdressService imyAdressService;

        public myAdressController(ImyAdressService imyAdressService)
        {
            this.imyAdressService = imyAdressService;
        }

        public IActionResult Index()
        {
            var values = imyAdressService.GetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddMyAdress()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddMyAdress(myAdress myAdress)
        {

            imyAdressService.Insert(myAdress);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteMyAdress(int id)
        {
            var sil = imyAdressService.GetById(id);
            imyAdressService.Delete(sil);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateMyAdress(int id)
        {
            var value = imyAdressService.GetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateMyAdress(myAdress m)
        {
            imyAdressService.Update(m);
            return RedirectToAction("Index");
        }
    }
}
