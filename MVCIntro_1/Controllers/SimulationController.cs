using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCIntro_1.Controllers
{
    public class SimulationController : Controller
    {
        // GET: Simulation
        public ActionResult Index()
        {
            return View();
        }
    }
}


//ViewResult