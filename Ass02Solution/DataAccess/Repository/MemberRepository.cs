using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        void IMemberRepository.Delete(Member m)
        => MemberDAO.Instance.Delete(m);    

        Member IMemberRepository.GetMember(string Email, string password)
        => MemberDAO.Instance.GetMember(Email, password);

        Member IMemberRepository.GetMemberByID(int Mid)
        => MemberDAO.Instance.GetMemberById(Mid);

        IEnumerable<Member> IMemberRepository.GetMembers()
        => MemberDAO.Instance.GetMembers();

        IEnumerable<Member> IMemberRepository.GetMembersByCompany(string CompanyName)
        => MemberDAO.Instance.GetByCompany(CompanyName);

        void IMemberRepository.Save(Member member)          
        => MemberDAO.Instance.Add(member);

        void IMemberRepository.Update(Member member)
       => MemberDAO.Instance.Update(member);
    }
}
