using InciAlbum.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace InciAlbum.ViewComponents
{
	public class _stuffPartial:ViewComponent
	{
		private readonly IStuffService stuffService;

		public _stuffPartial(IStuffService stuffService)
		{
			this.stuffService = stuffService;
		}

		public IViewComponentResult Invoke()
		{
			var values = stuffService.GetListAll();
			return View(values);
		}
	}
}
