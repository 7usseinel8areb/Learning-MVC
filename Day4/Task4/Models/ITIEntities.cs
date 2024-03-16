using Microsoft.EntityFrameworkCore;

namespace WebApplication4.Models
{
    public class ITIEntities : DbContext
    {
        public ITIEntities() : base()
        { }

        public DbSet<Department> Department { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Trainee> Trainee { get; set; }
        public DbSet<Instructor> Instructor { get; set; }
        public DbSet<crsResult> crsResult { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Instructor>()
                .HasOne(c => c.Department)
                .WithMany()
                .HasForeignKey(c => c.Department_ID)
                .OnDelete(DeleteBehavior.Restrict); // Specify the ON DELETE behavior here

            modelBuilder.Entity<crsResult>()
                .HasOne(c => c.Trainee)
                .WithMany()
                .HasForeignKey(c => c.Trainee_ID)
                .OnDelete(DeleteBehavior.Restrict); // Specify the ON DELETE behavior here

            // Your other configurations...

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = .;Initial Catalog = itiTask;Integrated Security = True;");
        }
    }
}
