using Data_Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject
{
    public class NewsDAO
    {
        private static NewsDAO instance;

        public static NewsDAO Instance
        {
            get
            {
                if(instance == null) return new NewsDAO();
                return instance;
            }
        }

        private NewsDAO() { }

        public void AddNews(News news)
        {
            try
            {
                using (PeDB peDB = new PeDB())
                {
                    peDB.News.Add(news);
                    peDB.SaveChanges();
                }
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
           
        }

        public void UpdateNews(News news)
        {
            try
            {
                using(PeDB pe = new PeDB())
                {
                    pe.Update(news);
                    pe.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);    
            }
        }

        public void DeleteNews(News news)
        {
            try
            {
                using(PeDB pe = new PeDB())
                {
                    pe.Remove(news);
                    pe.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<News> GetAllNews()
        {
            try
            {
                using(PeDB pe = new PeDB())
                {
                    return pe.News.ToList();
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public News GetNewsById(int id)
        {
            try
            {
                using(PeDB pe = new PeDB())
                {
                    return pe.News.FirstOrDefault(o => o.Id == id);
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public IEnumerable<News> GetNewsByUserId(int userId)
        {
            try
            {
                using(PeDB pe = new PeDB())
                {
                    return pe.News.Where(o => o.Id == userId).ToList();
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
