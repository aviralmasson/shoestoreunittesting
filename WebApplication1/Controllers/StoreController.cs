using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shoestore.Controllers
{
    public class Table_3Controller : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Browse(string brands)
        {
            ViewBag.brands = brands;
            return View();
        }

        public object Details(int v)
        {
            throw new NotImplementedException();
        }
    }
}