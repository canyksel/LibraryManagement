using LibraryManagement.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LibraryManagement.Entities.Concrete
{
    public class Book : IEntity
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int BookId { get; set; }

        [HiddenInput(DisplayValue = false)]
        public int AuthorId { get; set; }
        public string BookName { get; set; }
        public string Type { get; set; }
        public string AuthorName { get; set; }
        public string PublisherName { get; set; }
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime PublishDate { get; set; }
        public string Language { get; set; }
        public string Edition { get; set; }
        public decimal BookCost { get; set; }
        public int PageNumber { get; set; }
        public string BookDescription { get; set; }
        public bool InStock { get; set; }
        public int Quantity { get; set; }
    }
}
