using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class Default1Controller : Controller
    {
        //
        // GET: /Default1/

        public ActionResult Index()
        {
            return View();
        }

        public string About()
        {
            return "dupa po raz pierwszy";
        }

        public string Print()
        {
            return "dupa po raz drugi";
        }

        public int cps()
        {
            return 2;
        }
    }
}
