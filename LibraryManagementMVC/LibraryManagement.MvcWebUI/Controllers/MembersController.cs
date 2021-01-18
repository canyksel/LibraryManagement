using LibraryManagement.Business.Abstract;
using LibraryManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryManagement.MvcWebUI.Controllers
{
    public class MembersController : Controller
    {
        // GET: Members

        private IMemberService _memberService;

        public MembersController(IMemberService memberService)
        {
            _memberService = memberService;
        }

        public ActionResult MemberList()
        {
            return View(_memberService.GetAll().ToList());
        }

        public ActionResult CreateNewMember()
        {
            return View(new Member());
        }

        [HttpPost]
        public ActionResult CreateNewMember(HttpPostedFileBase file, Member member)
        {
            string fileName = Path.GetFileName(file.FileName);
            string _fileName = DateTime.Now.ToString("yymmssfff") + fileName;
            string extension = Path.GetExtension(file.FileName);
            string path = Path.Combine(Server.MapPath("~/Images/member_images/"), _fileName);

            member.ImagePath = "~/Images/member_images/" + _fileName;

            if (extension.ToLower() == ".jpg" || extension.ToLower() == ".jpeg" || extension.ToLower() == ".png")
            {
                if (file.ContentLength <= 1000000)
                {
                    _memberService.Add(member);
                    file.SaveAs(path);
                    return RedirectToAction("MemberList");
                }
            }

            return View(member);
        }

        public ActionResult MemberDetails(int id)
        {
            var member = _memberService.GetById(id);
            return View(member);
        }

        [HttpPost]
        public ActionResult MemberDetails(int id, Member member)
        {
            if (ModelState.IsValid)
            {
                _memberService.GetById(id);
                return RedirectToAction("Index");
            }
            return View(member);
        }

    }
}



//public ActionResult AddNewMember(Member member)
//{
//    if (ModelState.IsValid)
//    {
//        _memberService.Add(member);
//        return RedirectToAction("Index");
//    }

//    return View(member);
//}


//public ActionResult FileUpload(Member member, HttpPostedFileBase file)
//{
//    if (ModelState.IsValid)
//    {
//        if (file != null)
//        {
//            file.SaveAs(HttpContext.Server.MapPath("~/Images/")
//                                                  + file.FileName.LastIndexOf("."));
//            member.ImagePath = file.FileName;
//        }
//        _memberService.Add(member);
//        return RedirectToAction("AddNewMember", "Members");
//    }
//    return View(member);
//}