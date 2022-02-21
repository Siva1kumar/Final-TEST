using Mvcdress.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvcdress.Controllers
{
    public class MallController : Controller
    {
        // GET: Mall
        public ActionResult Index()
        {

            var com = new datacompount();
            var dress = com.GetAllDresses();

            return View(dress)
;
        }

    }
}