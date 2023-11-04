using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject
{
    public class EnrollmentDAO
    {
        public EnrollmentDAO() { }  
        private static EnrollmentDAO instance;

        public static EnrollmentDAO Instance
        {
            get
            {
                if(instance == null) return new EnrollmentDAO();
                return instance;
            }
        }

        public void Delete(Enrollments enrollments)
        {
            try
            {
                using (CourseDB db = new CourseDB())
                {
                    db.Entrollments.Remove(enrollments);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Add(Enrollments enrollments)
        {
            try
            {
                using (CourseDB db = new CourseDB())
                {
                    db.Entrollments.Add(enrollments);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(Enrollments enrollments)
        {
            try
            {
                using (CourseDB db = new CourseDB())
                {
                    db.Entrollments.Update(enrollments);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public IEnumerable<Enrollments> GetEnrollments()
        {
            try
            {
                using (CourseDB db = new CourseDB())
                {
                    return db.Entrollments.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
