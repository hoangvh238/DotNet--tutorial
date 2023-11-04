using Data_Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.Repository
{
    public class UserRepository : IUserRepository
    {
        public Users GetUser(string userName, string password)
        => UserDAO.Instance.GetUser(userName, password);
    }
}
