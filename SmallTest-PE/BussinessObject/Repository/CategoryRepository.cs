using Data_Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        public IEnumerable<Categories> GetAllCategories()
        => CategoriesDAO.Instance.GetCategories();

        public Categories GetCategory(string name)
        => CategoriesDAO.Instance.GetCategoryByName(name);
    }
}
