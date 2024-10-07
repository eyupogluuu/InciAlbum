using InciAlbum.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace InciAlbum.ViewComponents
{
	public class _footerPartial:ViewComponent
	{
		ImyAdressService ImyAdressService;

		public _footerPartial(ImyAdressService ımyAdressService)
		{
			ImyAdressService = ımyAdressService;
		}
		

		public IViewComponentResult Invoke()
		{
			var values = ImyAdressService.GetListAll();
			return View(values);
		}
	}
}
