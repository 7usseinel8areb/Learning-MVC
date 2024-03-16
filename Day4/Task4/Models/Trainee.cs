using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Trainee
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

        public string Image { get; set; }

        public string Address { get; set; }

        public decimal Grade { get; set; }

        [ForeignKey("Department")]
        public int Department_ID { get; set; }
        public Department Department { get; set; }

    }
}
