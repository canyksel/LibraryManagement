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
    public class MemberManager : IMemberService
    {
        private IMemberDal _memberDal;

        public MemberManager(IMemberDal memberDal)
        {
            _memberDal = memberDal;
        }

        public void Add(Member member)
        {
            _memberDal.Add(member);
        }

        public void Delete(Member member)
        {
            _memberDal.Delete(member);
        }

        public List<Member> GetAll()
        {
            return _memberDal.GetList().ToList();
        }

        public Member GetById(int id)
        {
            return _memberDal.Get(m => m.MemberId == id);
        }

        public List<Member> GetByLendId(int id)
        {
            throw new Exception();
        }

        public void Update(Member member)
        {
            _memberDal.Update(member);
        }
    }
}
