using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day2_Assignment.Models
{
    public class Course
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

        public decimal Degree { get; set; }

        public decimal minDegree { get; set; }

        [ForeignKey("Department")]
        public int Department_ID { get; set; }
        public Department Department { get; set; }
    }
}
