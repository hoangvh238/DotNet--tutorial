using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MemberDAO
    {
        private static MemberDAO instance;

        public static MemberDAO Instance
        {
            get
            {
                if (instance == null) return new MemberDAO();
                return instance;
            }
        }

        public MemberDAO() { }

        public Member GetMemberById(decimal id)
        {
            try
            {
                using(var context = new FstoreContext())
                {
                    return context.Members.Where(memeber => memeber.MemberId == id).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error when find user by id" + ex.Message);
            }
        }

        public Member GetMember(string email, string password) 
        {
            try
            {
                using(var context = new FstoreContext()) 
                {
                    return context.Members.FirstOrDefault(memeber => email == memeber.Email && password == memeber.Password);
                }
            }   
            catch (Exception ex)
            {
                throw new Exception("Error when authenticaion" + ex.Message);
            }
        }

        public IEnumerable<Member> GetMembers()
        {
            try
            {
                using(var context = new FstoreContext())
                {
                    return context.Members.ToList();
                }
             
            }
            catch(Exception ex)
            {
                throw new Exception("Error when get list memeber" + ex.Message);
            }
        }

        public void Update(Member member)
        {
            try
            {
                using(var context = new FstoreContext())
                {
                    context.Members.Update(member);
                    context.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Error when update"+ex.Message);    
            }
        }

        public void Delete(Member member) 
        {
            try
            {
                using (var context = new FstoreContext())
                {
                    context.Members.Remove(member);
                    context.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Error when delete memeber" + ex.Message);
            }
        }

        public void Add(Member member)
        {
            try
            {
                using(var context = new FstoreContext())
                {
                    context.Members.Add(member);
                    context.SaveChanges();
                }
            }
            catch(Exception e)
            {
                throw new Exception("Error when add memeber " + e.Message);
            }
        }

        public IEnumerable<Member> GetByCompany(string companyName)
        {
            try
            {
                using( var context = new FstoreContext())
                {
                    return context.Members.ToList().FindAll(member => member.CompanyName == companyName);
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Error when get by company" + ex.Message);
            }
        }

    }
}
