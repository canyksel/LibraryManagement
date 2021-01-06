using LibraryManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Business.Abstract
{
    public interface IBookService
    {
        List<Book> GetAll();
        Book GetById(int id);
        List<Book> GetByAuthorId(int id);
        //List<Book> GetByIsbn(string isbn);
        void Add(Book book);
        void Delete(Book book);
        void Update(Book book);
    }
}
