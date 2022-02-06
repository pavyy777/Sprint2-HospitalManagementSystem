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
    public class PatientRegController : ControllerBase
    {
        private PatientRegServices _patientRegServices;
        public PatientRegController(PatientRegServices patientRegServices)
        {
            _patientRegServices = patientRegServices;
        }
        [HttpGet("GetPatients")]
        public IEnumerable<PatientReg> GetPatients()
        {
            return _patientRegServices.GetPatients();
        }
        [HttpPost("AddPatient")]
        public IActionResult AddPatient([FromBody] PatientReg patientReg)
        {
            _patientRegServices.AddPatient(patientReg);
            return Ok(" Patient registered successfully!!");
        }
        [HttpDelete("DeletePatient")]
        public IActionResult DeletePatient(int PatientId)
        {
            _patientRegServices.DeletePatient(PatientId);
            return Ok("Patient deleted successfully!!");
        }
        [HttpPut("UpdatePatient")]
        public IActionResult UpdatePatient([FromBody] PatientReg patientReg)
        {
            _patientRegServices.UpdatePatient(patientReg);
            return Ok("Patient updated successfully!!");
        }
    }
}
