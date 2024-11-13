using Microsoft.AspNetCore.Mvc;

namespace PowerMap.ViewComponents
{
    public class _ScriptsComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
