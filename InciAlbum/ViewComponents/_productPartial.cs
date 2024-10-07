using InciAlbum.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace InciAlbum.ViewComponents
{
	public class _productPartial : ViewComponent
	{
		private readonly IProductService productService;

		public _productPartial(IProductService productService)
		{
			this.productService = productService;
		}

		public IViewComponentResult Invoke()
		{
			var values = productService.GetListAll();
			return View(values);
		}
	}
}
