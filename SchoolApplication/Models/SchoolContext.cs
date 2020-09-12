using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApplication.Models
{
    class SchoolContext : DbContext
    {
        public SchoolContext() : base("ConnectionString")
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //With Fluent API, Icould also create Many-to- Many relationship btw Course and Students.
            //modelBuilder.Entity<Course>().HasMany(x => x.Students).WithMany();


            base.OnModelCreating(modelBuilder);
        }
    }
}
