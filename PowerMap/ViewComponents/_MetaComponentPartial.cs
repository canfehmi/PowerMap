using Microsoft.AspNetCore.Mvc;

namespace PowerMap.ViewComponents
{
    public class _MetaComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
