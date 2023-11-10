using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataAccess.PeDB;

namespace DataAccess
{
    public class Doctor
    {
        public Doctor() { }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DoctorID { get; set; }
        public string DoctorName { get; set; }
        public string Address { get; set; }

        [ForeignKey(nameof(SpecializationID))]
        public int SpecializationID { get; set; }
        

    }

    public class Specialization
    {
        public Specialization() { }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SpecializationID { get; set; }
        public string SpecializationName { get; set; }
        public List<Doctor> Doctors { get; set; }


    }

 
    public class PeDB : DbContext
    {
        public PeDB() { }
        public virtual DbSet<Doctor> Doctors { get; set; }

        public virtual DbSet<Specialization> Specializations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json", true, true);
            IConfigurationRoot configuration = builder.Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("PRN211"));

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            



            //------------------------------------Insert Data----------------------------------------

        }


    }
}
