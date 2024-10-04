using FluentValidation.Results;
using InciAlbum.BusinessLayer.Abstract;
using InciAlbum.BusinessLayer.ValidationRules;
using InciAlbum.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace InciAlbum.Controllers
{
    public class ImageController : Controller
    {
        private readonly IImageService imageService;

        public ImageController(IImageService imageService)
        {
            this.imageService = imageService;
        }

        public IActionResult Index()
        {
           var values= imageService.GetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddImage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddImage(Image image)
        {
            ImageValidator iv= new ImageValidator();
            ValidationResult result=iv.Validate(image);//iv den gelen validati image nesnesi için kontrol et
            if (result.IsValid)
            {
                imageService.Insert(image);
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
        public IActionResult DeleteImage(int id)
        {
            var sil = imageService.GetById(id);
            imageService.Delete(sil);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateImage(int id)
        {
            var values = imageService.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateImage(Image image)
        {
            ImageValidator iv = new ImageValidator();
            ValidationResult result = iv.Validate(image);// validatorden gelen kısıtlamalrı ekledğim image için kontrol et
            if (result.IsValid)
            {
                imageService.Update(image);
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
