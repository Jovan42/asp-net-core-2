﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApp.Models;

namespace TestApp.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            var employee = new Employee { ID = 1, Name = "Mark Upston" };
            return View(employee);
        }
    }
}
