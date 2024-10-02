﻿using System.ComponentModel.DataAnnotations;

namespace auth.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string password { get; set; }

    }
}
