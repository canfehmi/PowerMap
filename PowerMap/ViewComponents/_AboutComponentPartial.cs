﻿using Microsoft.AspNetCore.Mvc;

namespace PowerMap.ViewComponents
{
    public class _AboutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
