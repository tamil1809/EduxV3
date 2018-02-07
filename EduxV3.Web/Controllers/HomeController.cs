﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EduxV3.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return File("/index.html", "text/html");
        }
    }
}