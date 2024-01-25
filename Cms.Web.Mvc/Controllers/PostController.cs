using Microsoft.AspNetCore.Mvc;

namespace Cms.Web.Mvc.Controllers
{
	public class PostController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult Details(int id)
		{
			return View();
		}
		public IActionResult Search(string quey, int id)
		{
			return View();
		}
	}
}
