using Microsoft.AspNetCore.Mvc;

namespace InciAlbum.ViewComponents
{
	public class _headPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
