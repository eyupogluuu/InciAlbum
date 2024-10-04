using InciAlbum.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace InciAlbum.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService contactService;

        public ContactController(IContactService contactService)
        {
            this.contactService = contactService;
        }

        public IActionResult Index()
        {
            var values = contactService.GetListAll();
            return View(values);
        }
        public IActionResult ContactDetails(int id)
        {
            var values = contactService.GetById(id);
            return View(values);
        }
        public IActionResult DeleteContact(int id)
        {
            var sil = contactService.GetById(id);
            contactService.Delete(sil);
            return RedirectToAction("Index");
        }
    }
}
