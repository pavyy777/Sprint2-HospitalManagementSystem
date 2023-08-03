using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HMS.Entity.Models
{
     public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "EmployeeName is Required")]
        [StringLength(35)]
        public string EmployeeName { get; set; }
        [Required(ErrorMessage = "EmployeeRole is Required")]
        public string EmployeeRole { get; set; }
        [Required(ErrorMessage = "Email is Required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "PhoneNumber is Required")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(10)]

        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Password is Required")]
        [DataType(DataType.Password)]
        [StringLength(8)]
        public string Password { get; set; }
        public string ReEnterPassword { get; set; }
    }
}
