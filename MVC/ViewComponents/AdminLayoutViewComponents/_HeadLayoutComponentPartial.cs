using Microsoft.AspNetCore.Mvc;

namespace MVC.ViewComponents.AdminLayoutViewComponents
{
	public class _HeadLayoutComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
