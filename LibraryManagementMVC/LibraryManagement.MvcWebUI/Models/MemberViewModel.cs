using LibraryManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagement.MvcWebUI.Models
{
    public class MemberViewModel
    {
        public List<Member>  Members { get; internal set; }

    }
}