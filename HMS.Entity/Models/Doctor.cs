using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HMS.Entity.Models
{
   public class Doctor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DoctorId { get; set; }
        [Required(ErrorMessage ="Name is Required")]
        [StringLength(35)]
        public string DoctorName { get; set; }
        [Required(ErrorMessage = "DoctorQualification is Required")]

        public string DoctorQualification { get; set; }
        [Required(ErrorMessage = "DoctorSpecialization is Required")]

        public string DoctorSpecialization { get; set; }

        public int ConsultFee { get; set; }
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
