using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace quote.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData.Model = Quote.ChooseRandomQuote();
            return View();
        }

        
    }
}