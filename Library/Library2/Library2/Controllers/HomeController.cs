using Library2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;


namespace Library2.Controllers
{
    public class HomeController : Controller
    {
        LibraryContext db = new LibraryContext();

        public ActionResult Index()
        {
            return View();
        }

       

        public ActionResult Contact()
        {
            return View();
        }
    }


}