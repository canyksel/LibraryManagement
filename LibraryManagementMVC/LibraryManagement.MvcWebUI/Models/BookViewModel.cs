using LibraryManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagement.MvcWebUI.Models
{
    public class BookViewModel
    {
        public List<Book> Books { get; internal set; }
    }
}