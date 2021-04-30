using LibraryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryApp.Controllers
{
    public class HomeController : Controller
    {
        // создаем контекст данных
        LibContext db = new LibContext();

            

            public ActionResult Index()
            {
                // получаем из бд все объекты Book
                IEnumerable<Book> books = db.Books;
                // передаем все объекты в динамическое свойство Books в ViewBag
                ViewBag.Books = books;
                // возвращаем представление
                return View();
            }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult LibView()
        {
            return null;
            //return View();
        }
    }
}