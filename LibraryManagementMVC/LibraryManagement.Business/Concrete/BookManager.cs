using LibraryManagement.Business.Abstract;
using LibraryManagement.DataAccess.Abstract;
using LibraryManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Business.Concrete
{
    public class BookManager : IBookService
    {
        private IBookDal _bookDal;   //Bu alan field alanıdır. bookDal a erişebilmek için yapılır. (Dependency Injection)

        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        public void Add(Book book)
        {
            //if (_bookDal.Get(b => b.BookName == book.BookName && b.AuthorId == book.AuthorId) == null)
            //{
            //    _bookDal.Add(book);

            //}
            //throw new Exception("Bu Kitap adı zaten mevcut");
            _bookDal.Add(book);
        }

        public void Delete(Book book)
        {
            _bookDal.Delete(book);
        }

        public List<Book> GetAll()
        {
            return _bookDal.GetList().ToList();
        }

        public List<Book> GetByAuthorId(int id)
        {
            return _bookDal.GetList(b => b.AuthorId == id).ToList();
        }

        public Book GetById(int id)
        {
            return _bookDal.Get(b => b.BookId == id);
        }

        public void Update(Book book)
        {
            _bookDal.Update(book);
        }

    }
}
