using Microsoft.AspNetCore.Mvc;

namespace InciAlbum.ViewComponents
{
	public class _footerPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
