using Data_Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject
{
    public class CategoriesDAO
    {
        private static CategoriesDAO instance;
        public static CategoriesDAO Instance
        {
            get
            {
                if(instance == null) return new CategoriesDAO();
                return instance;
            }
        }

        public CategoriesDAO() { }

        public IEnumerable<Categories> GetCategories()
        {
            try
            {
                using(PeDB pe = new PeDB())
                {
                    return pe.Categories.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Categories GetCategoryByName (string categoryName)
        {
            try
            {
                using(PeDB pe = new PeDB())
                {
                    return pe.Categories.FirstOrDefault(o => o.Name.Equals(categoryName));
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);    
            }
        }
    }
}
