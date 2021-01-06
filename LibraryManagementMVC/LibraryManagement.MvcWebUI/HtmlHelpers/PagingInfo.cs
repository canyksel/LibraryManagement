using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryManagement.MvcWebUI.HtmlHelpers
{
    public static class PagingInfo
    {
        public static MvcHtmlString YesNo(this HtmlHelper htmlHelper, bool yesNo)
        {
            var text = yesNo ? "STOKTA VAR" : "STOKTA YOK";
            return new MvcHtmlString(text);
        }
    }
}