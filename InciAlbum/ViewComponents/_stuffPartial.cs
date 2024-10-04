using Microsoft.AspNetCore.Mvc;

namespace InciAlbum.ViewComponents
{
	public class _stuffPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
