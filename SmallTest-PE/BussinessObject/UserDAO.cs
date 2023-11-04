using Data_Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject
{
    public class UserDAO
    {
        private static UserDAO instance;
        public static UserDAO Instance
        { get 
            {
                if(instance == null) return new UserDAO();
                return instance; 
            }
        }

        public UserDAO() { }

        public Users GetUser(String userName,String password)
        {
            try
            {
                using(PeDB pe = new PeDB())
                {
                    return pe.Users.FirstOrDefault(o => o.UserName == userName && o.Password == password);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
