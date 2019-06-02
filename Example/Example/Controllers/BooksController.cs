using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Example.Models;

namespace Example.Controllers
{
    public class BooksController : Controller
    {
        // GET: Books
        BookContext db = new BookContext();
        public ActionResult Index()
        {
            //ViewBag.books = db.Books.ToList();
            return View();
        }
    }
}