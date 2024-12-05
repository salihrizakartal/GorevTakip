using Microsoft.AspNetCore.Mvc;

namespace MVC.ViewComponents.AdminLayoutViewComponents
{
	public class _MainPanelLayoutComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
