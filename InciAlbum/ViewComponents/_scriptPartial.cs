using Microsoft.AspNetCore.Mvc;

namespace InciAlbum.ViewComponents
{
	public class _scriptPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
