using LibraryManagement.Business.Abstract;
using LibraryManagement.Business.Concrete;
using LibraryManagement.DataAccess.Concrete.EntityFramework;
using LibraryManagement.Entities.Concrete;
using LibraryManagement.MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryManagement.MvcWebUI.Controllers
{
    public class BooksController : Controller
    {
        // GET: Book

        private IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        public ActionResult Index()
        {
            List<Book> book = _bookService.GetAll();
            return View(book);

        }

        public ActionResult GetDetails(int id)
        {
            var book = _bookService.GetById(id);
            return View(book);
        }

        [HttpPost]
        public ActionResult GetDetails(int id, Book book)
        {
            if (ModelState.IsValid)
            {
                _bookService.GetById(id);
                return RedirectToAction("Index");
            }
            return View(book);
        }

        public ActionResult CreateNew()
        {
            return View(new Book());
        }

        [HttpPost]
        public ActionResult CreateNew(Book book)
        {
            if (ModelState.IsValid)
            {
                _bookService.Add(book);
                return RedirectToAction("Index");
            }

            return View(book);
        }

        public ActionResult EditBook(int id)
        {
            Book book = _bookService.GetById(id);
            return View(book);
        }

        [HttpPost]
        public ActionResult EditBook(Book book)
        {
            if (ModelState.IsValid)
            {
                _bookService.Update(book);
                return RedirectToAction("Index");
            }
            return View(book);
        }

    }
}
