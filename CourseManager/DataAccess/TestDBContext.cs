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
    public class Mem
    {
        public Mem() { }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string Address { get; set; }

        public Boolean Status { get; set; }
        public List<Enrollments> Enrollments { get; set; }
        public List<Exit> Exits { get; set; }
        public override string ToString()
        {
            // Trả về thông tin muốn hiển thị, ví dụ: "StudentName - CourseName"
            return $"{StudentName}";
        }

    }

  

    public class Join
    {
        public Join() { }
        public int StudentId { get; set; }
        public DateTime DateUpdate { get; set; }

        [ForeignKey("StudentId")]
        public virtual Students Student { get; set; }

    }

    public class Exit
    {
        public Exit() { }
        public int StudentId { get; set; }
        public int ExitID { get; set; }
        public DateTime DateUpdate { get; set; }

        [ForeignKey("StudentId")]
        public virtual Students Student { get; set; }

    }


    public class TestDB : DbContext
    {
        public TestDB() { }
        public virtual DbSet<Mem> Mems { get; set; }

        public virtual DbSet<Join> Joins { get; set; }

        public virtual DbSet<Exit> Exits { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json", true, true);
            IConfigurationRoot configuration = builder.Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("TestDB"));

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

    



            //------------------------------------Insert Data----------------------------------------

        }


    }
}
