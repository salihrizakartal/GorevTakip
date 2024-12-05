using Microsoft.AspNetCore.Mvc;

namespace MVC.ViewComponents.AdminLayoutViewComponents
{
	public class _ScriptsLayoutComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
