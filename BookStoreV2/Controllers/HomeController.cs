using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookStoreV2.Models;
using BookStoreV2.Util;

namespace BookStoreV2.Controllers
{
    public class HomeController : Controller
    {
        BookContext db = new BookContext();
        /*public ActionResult Index()
        {
            IEnumerable<Book> books = db.Books;

            ViewBag.Books = books;
            return View("View", db.Books);
        }*/
        public ActionResult Index()
        {
            IEnumerable<Book> books = db.Books;

        ViewBag.Books = books;
            return View("Index", db.Books);
        }
    public ActionResult Edit(int Id)
        {
            IEnumerable<Book> book = db.Books.Where(x => x.Id == Id);
            return View("Edit", book);
        }
        public ActionResult SomeMethod()
        {
            ViewData["Head"] = "Hello world!";
           /* if(ViewData["Head"].ToString()=="Hello world!")
            {
                return new HttpUnauthorizedResult();
            }*/
            return View("SomeMethod");
        }
       [HttpGet]
       public ActionResult Buy(int id)
       {
            ViewBag.BookId = id;
            return View();
       }



        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.Date = DateTime.Now;

            db.Purchases.Add(purchase);
            db.SaveChanges();
            return "Спасибо, " + purchase.Person + ", за покупку!";

        }

        public string Square(int a, int b, double y)
        {
            double s = (a * b * Math.Sin(y)) * 0.5;
            return "<h2>Площадь треугольника сторона 1 " + a +
                    " сторона 2 " + b + " и углом между ними " +y+ " равна " + s + "</h2>";
        }

        public ActionResult GetHtml()
        {
            return new HtmlResult("<h2>Hellp world!</h2>");
        }


    }
}