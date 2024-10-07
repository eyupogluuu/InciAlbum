using FluentValidation.Results;
using InciAlbum.BusinessLayer.Abstract;
using InciAlbum.BusinessLayer.ValidationRules;
using InciAlbum.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace InciAlbum.ViewComponents
{
	public class _contactPartial:ViewComponent
	{

		private readonly IContactService contactService;

		public _contactPartial(IContactService contactService)
		{
			this.contactService = contactService;
		}
		[HttpGet]
		public IViewComponentResult Invoke()
		{
			return View();
		}
		

	}
}
