using Microsoft.AspNetCore.Mvc;

namespace dolphinsblog.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult Footer()
        {
            ViewData["CurrentYear"] = 2024;
            return PartialView();
        }
    }
}
