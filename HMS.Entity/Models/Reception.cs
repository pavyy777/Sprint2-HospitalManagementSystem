using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HMS.Entity.Models
{
    public class Reception
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AppointmentId { get; set; }
        [Required(ErrorMessage = "AppointmentTime is Required")]
        [DataType(DataType.DateTime)]
        public DateTime AppointmentTime { get; set; }
        [Required(ErrorMessage = "DoctorId is Required")]

        public string DoctorId { get; set; }
        [Required(ErrorMessage = "PatientId is Required")]

        public string PatientId { get; set; }
    }
}
