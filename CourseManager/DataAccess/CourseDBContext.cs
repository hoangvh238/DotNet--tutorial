using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataAccess.CourseDB;

namespace DataAccess
{
    public class Students
    {
        public Students() { }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string Address { get; set; }

        public Boolean Status { get; set; }
        public List<Enrollments> Enrollments { get; set; }
        public override string ToString()
        {
            // Trả về thông tin muốn hiển thị, ví dụ: "StudentName - CourseName"
            return $"{StudentName}";
        }

    }

    public class Courses
    {
        public Courses() { }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseId { get; set; }
        public string CourseName { get; set; }

        public Boolean Status { get; set; }

        public List<Enrollments> Enrollments { get; set; }


    }

    public class Enrollments
    {
        public Enrollments() { }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public DateTime DateUpdate { get; set; }

        [ForeignKey("StudentId")]
        public virtual Students Student { get; set; }

        [ForeignKey("CourseId")]
        public virtual Courses Course { get; set; }
    }
    public class CourseDB : DbContext
    {
        public CourseDB() { }
        public virtual DbSet<Students> Students { get; set; }

        public virtual DbSet<Courses> Courses { get; set; }

        public virtual DbSet<Enrollments> Entrollments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json", true, true);
            IConfigurationRoot configuration = builder.Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("CourseDB"));

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Enrollments>()
                 .HasKey(e => new { e.StudentId, e.CourseId });

            modelBuilder.Entity<Students>(entity =>
            {
                entity.Property(e => e.StudentName)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });



            //------------------------------------Insert Data----------------------------------------

        }


    }
}
