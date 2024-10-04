using Microsoft.AspNetCore.Mvc;

namespace InciAlbum.ViewComponents
{
	public class _contactPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
