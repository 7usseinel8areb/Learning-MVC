using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day2_Assignment.Models
{
    public class crsResult
    {
        [Key]
        public int ID { get; set; }

        public decimal degree { get; set; }

        [ForeignKey("Course")]
        public int Course_ID { get; set; }
        public Course Course { get; set; }

        [ForeignKey("Trainee")]
        public int Trainee_ID { get; set;}
        public Trainee Trainee { get; set; }
    }
}
