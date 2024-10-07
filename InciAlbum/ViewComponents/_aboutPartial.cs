using InciAlbum.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace InciAlbum.ViewComponents
{
	public class _aboutPartial : ViewComponent
	{
		private readonly IAboutService aboutService;

        public _aboutPartial(IAboutService aboutService)
        {
            this.aboutService = aboutService;
        }

        public IViewComponentResult Invoke()
		{
			var values = aboutService.GetListAll();
			return View(values);
		}
	}
}
