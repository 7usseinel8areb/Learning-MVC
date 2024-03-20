using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Department
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Name Can be changed when display")]
        public string Name { get; set; }
        public string Manager { get; set; }
    }
}
