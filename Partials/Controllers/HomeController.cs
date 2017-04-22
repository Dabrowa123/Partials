using Partials.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Partials.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Przyklad()
        {
            return View();
        }
        public ActionResult Index()
        {
            List<Kurs> kursy = new List<Kurs>
            {
                new Kurs { nazwa= "1caskmcna", opis= "knasdlkcna" },
                new Kurs { nazwa= "2caskmcna", opis= "knasdlkcna" },
                new Kurs { nazwa= "3caskmcna", opis= "knasdlkcna" },
                new Kurs { nazwa= "4caskmcna", opis= "knasdlkcna" },
                new Kurs { nazwa= "5caskmcna", opis= "knasdlkcna" },
                new Kurs { nazwa= "6caskmcna", opis= "knasdlkcna" },
                new Kurs { nazwa= "7caskmcna", opis= "knasdlkcna" },
                new Kurs { nazwa= "8caskmcna", opis= "knasdlkcna" },
            };

            return View(kursy);
        }

        [ChildActionOnly]
        public ActionResult ShowTimePartial()
        {
            var time = DateTime.Now.ToLongTimeString();
            return PartialView("_PartialTime", time);
        }

        public string ShowTime()
        {
            return DateTime.Now.ToLongTimeString();
        }
    }
}