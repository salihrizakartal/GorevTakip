using Microsoft.AspNetCore.Mvc;

namespace MVC.ViewComponents.AdminLayoutViewComponents
{
	public class _SidebarLayoutComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
