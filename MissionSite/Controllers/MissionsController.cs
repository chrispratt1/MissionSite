using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MissionSite.Controllers
{
    public class MissionsController : Controller
    {
        // GET: Missions
        public ActionResult Index()
        {
            ViewBag.Message = "Missions";

            return View();
        }

        public ActionResult Faq( string name, string mpName, string address, string language, string climate, string religion, string flag)
        {
            ViewBag.name = name;
            ViewBag.mpName = mpName;
            ViewBag.address = address;
            ViewBag.language = language;
            ViewBag.climate = climate;
            ViewBag.religion = religion;
            ViewBag.flag = flag;

            ViewBag.q1 = "How can I best prepare spiritually to be a missionary?";
            ViewBag.q2 = "How can I best prepare emotionally to be a missionary?";
            ViewBag.q3 = "Should I wait until I have saved enough money to go?";
            ViewBag.q4 = "Do I have to meet physical requirements to serve a mission?";

            return View();
        }

        public ActionResult Videos()
        {
            return View();
        }
    }
}