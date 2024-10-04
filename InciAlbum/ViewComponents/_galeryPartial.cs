using Microsoft.AspNetCore.Mvc;

namespace InciAlbum.ViewComponents
{
	public class _galeryPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
