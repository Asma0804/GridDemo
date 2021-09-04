using GridDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GridDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Details()
        {
            SchemeEntities GVDB = new SchemeEntities();

            var SchemeList = (from scheme in GVDB.SchemeMasters
                              select scheme).ToList();
            return View(SchemeList);
        }
    }
}