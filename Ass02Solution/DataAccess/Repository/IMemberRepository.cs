using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public  interface IMemberRepository
    {
        IEnumerable<Member> GetMembers();
        void Save(Member member);
        void Update(Member member);
        void Delete(Member m);
        Member GetMemberByID(int Mid);
        IEnumerable<Member> GetMembersByCompany(string CompanyName);
        Member GetMember(string Email, string password);
    }
}
