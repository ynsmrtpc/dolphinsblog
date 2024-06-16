using Microsoft.AspNetCore.Mvc;

namespace dolphinsblog.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult BlogList() 
        {
            return PartialView();
        }
        
        public PartialViewResult FeaturedPost()
        {
            return PartialView();
        }

        public PartialViewResult OtherFeaturedPost()
        {
            return PartialView();
        }
        public PartialViewResult MailSubscribe()
        {
            return PartialView();
        }

        public IActionResult BlogDetails()
        {
            return View();
        }
        public PartialViewResult BlogCover()
        {
            return PartialView();
        }
    }
}
