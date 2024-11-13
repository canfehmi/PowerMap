using Microsoft.AspNetCore.Mvc;

namespace PowerMap.ViewComponents
{
    public class _ClientsComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
