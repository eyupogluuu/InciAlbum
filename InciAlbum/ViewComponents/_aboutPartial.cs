using Microsoft.AspNetCore.Mvc;

namespace InciAlbum.ViewComponents
{
	public class _aboutPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
