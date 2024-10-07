using InciAlbum.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace InciAlbum.ViewComponents
{
	public class _galeryPartial:ViewComponent
	{
		private readonly IImageService ımageService;

		public _galeryPartial(IImageService ımageService)
		{
			this.ımageService = ımageService;
		}

		public IViewComponentResult Invoke()
		{
			var values = ımageService.GetListAll();
			return View(values);
		}
	}
}
