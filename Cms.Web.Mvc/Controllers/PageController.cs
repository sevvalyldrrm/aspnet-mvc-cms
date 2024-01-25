using Microsoft.AspNetCore.Mvc;

namespace Cms.Web.Mvc.Controllers
{
	public class PageController : Controller
	{
		public IActionResult Detail(int id)
		{
			return View();
		}
	}
}
