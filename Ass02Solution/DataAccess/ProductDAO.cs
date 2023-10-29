using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProductDAO
    {
        private static ProductDAO instance;

    private ProductDAO()
    {
    }

    public static ProductDAO Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new ProductDAO();
            }
            return instance;
        }
    }
    }
}
