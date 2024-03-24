using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Department
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Name Can be changed when display")]
        [StringLength(2, ErrorMessage = "Department name must contain exactly two letters")]
        public string Name { get; set; }
        public string Manager { get; set; }
    }
}
