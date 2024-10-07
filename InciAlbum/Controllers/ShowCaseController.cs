using FluentValidation.Results;
using InciAlbum.BusinessLayer.Abstract;
using InciAlbum.BusinessLayer.ValidationRules;
using InciAlbum.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace InciAlbum.Controllers
{
	public class ShowCaseController : Controller
	{
		private readonly IContactService contactService;

		public ShowCaseController(IContactService contactService)
		{
			this.contactService = contactService;
		}

		public IActionResult Index()
		{
			return View();
		}
		[HttpGet]
		public PartialViewResult AddContact()
		{
			return PartialView();
		}
		[HttpPost]
		public IActionResult AddContact(Contact c)
		{
			ContactValidator cv = new ContactValidator();
			ValidationResult result = cv.Validate(c);
			if (result.IsValid)
			{
				c.date = DateTime.Parse(DateTime.Now.ToShortDateString());
				contactService.Insert(c);
				return RedirectToAction("Index");
			}
			else
			{
				foreach (var item in result.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}
			return View("Index", c);
		}


	}
}
