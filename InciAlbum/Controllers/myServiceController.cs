using InciAlbum.BusinessLayer.Abstract;
using InciAlbum.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace InciAlbum.Controllers
{
    public class myServiceController : Controller
    {
        private readonly ImyServiceService ımyServiceService;

        public myServiceController(ImyServiceService ımyServiceService)
        {
            this.ımyServiceService = ımyServiceService;
        }

        public IActionResult Index()
        {
            var values = ımyServiceService.GetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddService()
        {
            return View();

        }
        [HttpPost]
        public IActionResult AddService(myService service)
        {
            ımyServiceService.Insert(service);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteService(int id)
        {
            var sil = ımyServiceService.GetById(id);
            ımyServiceService.Delete(sil);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateService(int id)
        {
            var serv = ımyServiceService.GetById(id);
            return View(serv);
        }
        [HttpPost]
        public IActionResult UpdateService(myService service)
        {
            ımyServiceService.Update(service);
            return RedirectToAction("Index");
        }
    }
}
