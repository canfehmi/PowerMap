﻿using Microsoft.AspNetCore.Mvc;

namespace PowerMap.ViewComponents
{
    public class _FooterComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}