using System.ComponentModel.DataAnnotations;

namespace Day2_Assignment.Models
{
    public class Department
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Manager { get; set; }
    }
}
