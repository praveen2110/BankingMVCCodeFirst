using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Repository;
using System.Dynamic;

namespace BankingApplication_2MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //public ActionResult Index(String String)
        //{
        //    ViewData["name"] = String;
        //    return View();
        //}

        public ActionResult Index()
        {
            UserRepository urepo = new UserRepository();

            return View(urepo.GetAll());
        }

    }
}