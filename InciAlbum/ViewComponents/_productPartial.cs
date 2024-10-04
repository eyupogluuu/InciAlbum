using Microsoft.AspNetCore.Mvc;

namespace InciAlbum.ViewComponents
{
	public class _productPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{ return View(); }
	}
}
