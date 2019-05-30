﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExampleApp.Models;

namespace ExampleApp.Controllers
{
    public class HomeController : Controller
    {
        Repository repo;

        public HomeController()
        {
            repo = Repository.Current;
        }
        
        // GET: Home
        public ActionResult Index()
        {
            return View(repo.Products);
        }
    }
}