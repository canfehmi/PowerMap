using Microsoft.AspNetCore.Mvc;

namespace PowerMap.ViewComponents
{
    public class _HeaderComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
