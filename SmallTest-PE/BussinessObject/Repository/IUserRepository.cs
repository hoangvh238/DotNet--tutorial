using Data_Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.Repository
{
    public interface IUserRepository
    {
        Users GetUser(string userName, string password);

    }
}
