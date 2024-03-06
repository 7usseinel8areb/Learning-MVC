using Microsoft.EntityFrameworkCore;

namespace Day2_Assignment.Models
{
    public class ITIEntities:DbContext
    {
        public ITIEntities() : base()
        { }

        public DbSet<Instructor> Instructor { get; set; }

        public DbSet<Department> Department { get; set; }

        public DbSet<Course> Course { get; set; }

        public DbSet<Trainee> Trainee { get; set; }

        public DbSet<crsResult> crsResult { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = .;Initial Catalog = itiTask;Integrated Security = True;");
        }
    }
}
