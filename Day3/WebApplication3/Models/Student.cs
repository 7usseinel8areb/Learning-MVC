using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class Student
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public int Age { get; set; }

        public string Image { get; set; }

        [ForeignKey("Department")]
        public int Dept { get; set; }

        public Department Department { get; set; }
    }
}
