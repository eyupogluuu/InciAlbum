using Microsoft.AspNetCore.Mvc;

namespace InciAlbum.ViewComponents
{
	public class _myServicePartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
