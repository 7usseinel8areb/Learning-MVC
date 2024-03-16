﻿using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Department
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Manager { get; set; }
    }
}
