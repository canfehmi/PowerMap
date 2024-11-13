using Microsoft.AspNetCore.Mvc;

namespace PowerMap.ViewComponents
{
    public class _ServicesComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
