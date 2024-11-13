using Microsoft.AspNetCore.Mvc;

namespace PowerMap.ViewComponents
{
    public class _TestimonialsComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
