using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace dolphinsblog.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager categoryManager = new CategoryManager();

        public IActionResult Index()
        {
            var categories = categoryManager.GetAll();
            return View(categories);
        }
    }
}
