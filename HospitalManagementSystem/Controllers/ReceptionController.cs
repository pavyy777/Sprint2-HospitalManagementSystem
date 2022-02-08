using HMS.BAL.Services;
using HMS.Entity.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceptionController : ControllerBase
    {
        private ReceptionServices _receptionServices;
        public ReceptionController(ReceptionServices receptionServices)
        {
            _receptionServices = receptionServices;
        }
        [HttpGet("GetAppointments")]
        public IEnumerable<Reception> GetAppointments()
        {
            return _receptionServices.GetAppointments();
        }
        public IActionResult GetAppointmentById(int AppointmentId)
        {
            _receptionServices.GetAppointmentById(AppointmentId);
            return Ok("Success");
        }
        [HttpPost("AddAppointment")]
        public IActionResult AddAppointment([FromBody] Reception reception)
        {
            _receptionServices.AddAppointment(reception);
            return Ok(" Appointment booked successfully!!");
        }
        [HttpDelete("DeleteAppointment")]
        public IActionResult DeleteAppointment(int AppointmentId)
        {
            _receptionServices.DeleteAppointment(AppointmentId);
            return Ok("Appointment has been cancelled!!");
        }
        [HttpPut("UpdateAppointment")]
        public IActionResult UpdateAppointment([FromBody] Reception reception)
        {
            _receptionServices.UpdateAppointment(reception);
            return Ok(" Appointment schedule has been updated!!");
        }
    }
}
