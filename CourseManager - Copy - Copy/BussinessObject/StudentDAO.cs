using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BussinessObject
{
    public class StudentDAO
    {
        public StudentDAO() { } 
        private static StudentDAO instance; 

        public static StudentDAO Instance
        {
           get {
                if(instance == null) return new StudentDAO();
                return instance;
            }
        }

        public IEnumerable <Students> GetAllStudents ()
        {
            try
            {
                using(CourseDB db = new CourseDB())
                {
                    return db.Students.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Students GetStudentById (int id)
        {
            try
            {
                using (CourseDB db = new CourseDB())
                {
                    return db.Students.ToList().FirstOrDefault(o => o.StudentId == id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<Students> GetStudentByName (string name)
        {
            try
            {
                using (CourseDB db = new CourseDB())
                {
                    return db.Students.Where(o => o.StudentName.Contains(name)).ToList(); 
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Add (Students student)
        {
            try
            {
                using (CourseDB db = new CourseDB())
                {
                     db.Students.Add(student);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Delete(Students student)
        {
            try
            {
                using (CourseDB db = new CourseDB())
                {
                    db.Students.Remove(student);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(Students student)
        {
            try
            {
                using (CourseDB db = new CourseDB())
                {
                    db.Students.Update(student);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
