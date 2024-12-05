using Microsoft.AspNetCore.Mvc;

namespace MVC.ViewComponents.AdminLayoutViewComponents
{
	public class _FooterLayoutComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
