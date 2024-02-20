using Microsoft.AspNetCore.Mvc;

namespace Cms.Web.Mvc.Controllers
{
	public class DepartmentController : Controller
	{
		public IActionResult Index(int id, int page)
		{
			return View();
		}
	}
}
