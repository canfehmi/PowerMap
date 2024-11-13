using Microsoft.AspNetCore.Mvc;

namespace PowerMap.ViewComponents
{
    public class _BannerComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
