using Microsoft.AspNetCore.Mvc;

namespace InciAlbum.ViewComponents
{
	public class _noticePartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();	
		}
	}
}
