using InciAlbum.BusinessLayer.Abstract;
using InciAlbum.DataAccessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace InciAlbum.ViewComponents
{
	public class _myServicePartial:ViewComponent
	{
		private readonly ImyServiceService ımy;

		public _myServicePartial(ImyServiceService ımy)
		{
			this.ımy = ımy;
		}

		public IViewComponentResult Invoke()
		{
			var values = ımy.GetListAll();
			return View(values);
		}
	}
}
