﻿using Microsoft.AspNetCore.Mvc;

namespace PowerMap.ViewComponents
{
    public class _PortfolioComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
