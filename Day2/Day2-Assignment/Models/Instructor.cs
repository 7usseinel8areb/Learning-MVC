﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day2_Assignment.Models
{
    public class Instructor
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

        public string Image { get; set; }

        public decimal Salary { get; set; }

        public string Address { get; set; }

        [ForeignKey("Department")]
        public int Department_ID { get; set; }
        public Department Department { get; set; }

        [ForeignKey("Course")]
        public int Course_ID { get; set; }
        public Course Course { get; set; }
    }
}
