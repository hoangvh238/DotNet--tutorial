using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject
{
    public class CourseDAO
    {
        public CourseDAO() { }

        private static CourseDAO instace;

        public static CourseDAO Instance
        {
            get
            {
                if(instace == null) return new CourseDAO();
                return instace;
            }
        }

        public void Add(Courses course)
        {
            try
            {
                using (CourseDB db = new CourseDB())
                {
                    db.Courses.Add(course);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Delete(Courses course)
        {
            try
            {
                using (CourseDB db = new CourseDB())
                {
                    db.Courses.Remove(course);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(Courses course)
        {
            try
            {
                using (CourseDB db = new CourseDB())
                {
                    db.Courses.Update(course);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<Courses> GetAllCourse ()
        {
            try
            {
                using (CourseDB db = new CourseDB())
                {
                   return db.Courses.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public Courses GetCourseByID (int id)
        {
            try
            {
                using (CourseDB db = new CourseDB())
                {
                   return  db.Courses.ToList().FirstOrDefault(o => o.CourseId == id);
               
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Courses GetCourseByName (string name)
        {
            try
            {
                using (CourseDB db = new CourseDB())
                {
                    return db.Courses.ToList().FirstOrDefault(o => o.CourseName == name);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
