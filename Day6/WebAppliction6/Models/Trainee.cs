using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Trainee
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public string Image { get; set; }

        public string Address { get; set; }
        [RegularExpression(@"^(?:[0-3](?:\.\d{1,2})?|4(?:\.0{1,2})?)$", ErrorMessage ="GPA must be between 0 and 4")]
        public decimal Grade { get; set; }

        [ForeignKey("Department")]
        public int Department_ID { get; set; }
        public Department Department { get; set; }

    }
}
