using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FirstMvcProject.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "Please fill the ID area")]
        public int ID { get; set; }

        [Required(ErrorMessage ="Please fill the name area")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please fill the salary area")]
        [Range(100, 500, ErrorMessage ="You salary must be bettween 100 and 500")]
        public int Salary { get; set; }
    }
}