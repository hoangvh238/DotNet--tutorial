using Data_Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.Repository
{
    public interface ICategoryRepository
    {
        IEnumerable<Categories> GetAllCategories();
        Categories GetCategory(string name);
    }
}
