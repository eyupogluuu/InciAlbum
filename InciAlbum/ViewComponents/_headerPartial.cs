using Microsoft.AspNetCore.Mvc;

namespace InciAlbum.ViewComponents
{
	public class _headerPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{ return View(); }
	}
}
