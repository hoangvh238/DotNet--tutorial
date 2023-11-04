using Data_Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.Repository
{
    public interface INewsRepository
    {
        IEnumerable<News> GetAllNews();
        News GetNewsById(int id);
        IEnumerable<News> GetNewsByUserId(int userId);  

        void DeleteNews(News newNews);
        void AddNews(News newNews); 
        void UpdateNews(News newNews);

    }
}
