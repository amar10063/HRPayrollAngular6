﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HRPayrollAngular6.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Service()
        {
            ViewBag.Message = "Your Service  page.";

            return View();
        }
        public ActionResult Team()
        {
            ViewBag.Message = "Your Team  page.";

            return View();
        }

        public ActionResult job()
        {
            ViewBag.Message = "Your job  page.";

            return View();
        }
    }
}