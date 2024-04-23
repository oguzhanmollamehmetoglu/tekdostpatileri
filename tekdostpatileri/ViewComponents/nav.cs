using Microsoft.AspNetCore.Mvc;

namespace tekdostpatileri.ViewComponents
{
	public class nav:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
