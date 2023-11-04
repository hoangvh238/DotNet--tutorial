using Data_Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.Repository
{
    public class NewsRepository : INewsRepository
    {
        public void AddNews(News newNews)
       => NewsDAO.Instance.AddNews(newNews);

        public void DeleteNews(News news)
        => NewsDAO.Instance.DeleteNews(news);

        public IEnumerable<News> GetAllNews()
       => NewsDAO.Instance.GetAllNews();

        public News GetNewsById(int id)
        => NewsDAO.Instance.GetNewsById(id);

        public IEnumerable<News> GetNewsByUserId(int userId)
        => NewsDAO.Instance.GetNewsByUserId(userId);

        public void UpdateNews(News newNews)
       => NewsDAO.Instance.UpdateNews(newNews);
    }
}
