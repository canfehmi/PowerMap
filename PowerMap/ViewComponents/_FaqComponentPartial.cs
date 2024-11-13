using Microsoft.AspNetCore.Mvc;

namespace PowerMap.ViewComponents
{
    public class _FaqComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
