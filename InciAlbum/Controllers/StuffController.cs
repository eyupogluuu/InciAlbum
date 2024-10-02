using FluentValidation.Results;
using InciAlbum.BusinessLayer.Abstract;
using InciAlbum.BusinessLayer.ValidationRules;
using InciAlbum.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;


namespace InciAlbum.Controllers
{
    public class StuffController : Controller
    {
        private readonly IStuffService stuffService;

        public StuffController(IStuffService stuffService)
        {
            this.stuffService = stuffService;
        }

        public IActionResult Index()
        {
            var values = stuffService.GetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddStuff() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddStuff(Stuff stuff)
        {
            StuffValidator sv = new StuffValidator();
            ValidationResult result = sv.Validate(stuff);// validatorden gelen kısıtlamalrı ekledğim stuff için kontrol et
            if (result.IsValid)
            {
                stuffService.Insert(stuff);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public IActionResult DeleteStuff(int id)
        {
            var sil=stuffService.GetById(id);
            stuffService.Delete(sil);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateStuff(int id)
        {
            var values=stuffService.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateStuff(Stuff stuff)
        {
            StuffValidator sv = new StuffValidator();
            ValidationResult result = sv.Validate(stuff);// validatorden gelen kısıtlamalrı ekledğim stuff için kontrol et
            if (result.IsValid)
            {
                stuffService.Update(stuff);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}
