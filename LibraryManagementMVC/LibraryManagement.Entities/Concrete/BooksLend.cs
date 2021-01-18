using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Entities.Concrete
{
    public class BooksLend
    {
        List<LendLine> _lendLines = new List<LendLine>();

        public void LendBook(Book book, int quantity)
        {
            LendLine lendLine = _lendLines.FirstOrDefault(b => b.Book.BookId == book.BookId);
            if (lendLine == null)
            {
                _lendLines.Add(new LendLine { Book = book, Quantity = quantity });
            }
            else
            {
                lendLine.Quantity += quantity;
            }
        }

        public void RemoveLendBook(Book book)
        {
            _lendLines.RemoveAll(b => b.Book.BookId == book.BookId);
        }
        public void Clear()
        {
            _lendLines.Clear();
        }

        public List<LendLine> Lines
        {
            get { return _lendLines; }
        }

    }

    public class LendLine
    {
        public Book Book { get; internal set; }
        public int Quantity { get; internal set; }
    }
}
