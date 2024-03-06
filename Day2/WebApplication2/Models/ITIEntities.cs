using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebApplication2.Models
{
    //Database Name - server - Authentication 
    public class ITIEntities: DbContext
    {
        public ITIEntities():base()
        {
            
        }
        public DbSet<Student> Student { get; set; }
        public DbSet<Department> Department { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source =.; Initial Catalog = ITI_DB; Integrated Security = True;");
                                        //dbms - name server - DB - auth
        }
    }
}
