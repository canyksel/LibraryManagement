using LibraryManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DataAccess.Concrete.EntityFramework
{
    public class LibraryManagementContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
    }
}
