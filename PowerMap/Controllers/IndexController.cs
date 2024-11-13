using Microsoft.AspNetCore.Mvc;

namespace PowerMap.Controllers
{
    public class IndexController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
