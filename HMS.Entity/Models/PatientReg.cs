using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HMS.Entity.Models
{
     public class PatientReg
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PatientId { get; set; }
        [Required(ErrorMessage = "PatientName is Required")]
        [StringLength(35)]
        public string PatientName { get; set; }
        [Required(ErrorMessage = "AdmissionDate is Required")]
        [DataType(DataType.Date)]

        public string AdmissionDate { get; set; }
        [Required(ErrorMessage = "Age is Required")]
      
        public int Age { get; set; }
        [Required(ErrorMessage = "Gender is Required")]

        public string Gender { get; set; }
        [Required(ErrorMessage = "Address is Required")]

        public string Address { get; set; }
        [Required(ErrorMessage = "PhoneNumber is Required")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(10)]

        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "BloodGroup is Required")]

        public string BloodGroup { get; set; }
        public string PatientIssue { get; set; }
        public string PatientType { get; set; }
        [Required(ErrorMessage = "DoctorName is Required")]
        [StringLength(35)]
        public string DoctorName { get; set; }
        [Required(ErrorMessage = "DoctorType is Required")]

        public string DoctorType { get; set; }
        [Required(ErrorMessage = "WardNumber is Required")]

        public int WardNumber { get; set; }
        [Required(ErrorMessage = "BedNumber is Required")]

        public int BedNumber { get; set; }
    }
}
