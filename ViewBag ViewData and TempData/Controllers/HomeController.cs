using System;
using System.Collections.Generic;
using System.Web.Mvc;
using ViewBag_ViewData_and_TempData.Models;

namespace ViewBag_ViewData_and_TempData.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //! has the shorted lifecycle, destroys after changing one view
            TempData["Message"] = "Message from TempData";

            string[] games = { "Counter Strike", "PUBG", "ARMA 3", "DayZ", "Grand Theft Auto" };

            TempData["Games"] = games;
            return View();
        }

        public ActionResult About()
        {
            if(TempData["Games"] != null)
            {
                TempData["Games"].ToString();
            } 
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}