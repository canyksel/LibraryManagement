using LibraryManagement.Business.Abstract;
using LibraryManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryManagement.MvcWebUI.Controllers
{
    public class LendBooksController : Controller
    {
        // GET: LendBook
        private IBookService _bookService;

        public LendBooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        public RedirectToRouteResult AddBookToLendList(int id)
        {
            Book book = _bookService.GetById(id);
            var bookcart = (BooksLend)Session["bookcart"];

            if (bookcart == null)
            {
                bookcart = new BooksLend();
                Session["bookcart"] = bookcart;
            }
            bookcart.LendBook(book, 1);
            return RedirectToAction("LendBook", bookcart);
        }
        public ViewResult LendBook()
        {
            var bookcart = (BooksLend)Session["bookcart"];
            return View(bookcart);
        }

        public RedirectToRouteResult RemoveBookFromLendList(int id)
        {
            Book book = _bookService.GetById(id);
            var bookcart = (BooksLend)Session["bookcart"];

            bookcart.RemoveLendBook(book);
            return RedirectToAction("LendBook", bookcart);
        }
        //public ViewResult LendBook()
        //{
        //    var bookcart = (BooksLend)Session["bookcart"];
        //    return View(bookcart);
        //}


        //if (bookcart.Lines.Count==0)
        //{
        //    ModelState.AddModelError("","Listede Kitap yok !");
        //}
        //else
        //{
        //    bookcart.RemoveLendBook(book);

        //}



    }
}