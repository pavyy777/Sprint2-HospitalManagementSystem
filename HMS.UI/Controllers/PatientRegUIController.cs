using HMS.Entity.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HMS.UI.Controllers
{
    public class PatientRegUIController : Controller
    {
        private IConfiguration _configuration;
        public PatientRegUIController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<PatientReg> patientresult = null;
            using (HttpClient client = new HttpClient())
            {
                string endPoint = _configuration["WebApiBaseUrl"] + "PatientReg/GetPatients";
                using (var response = await client.GetAsync(endPoint))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        patientresult = JsonConvert.DeserializeObject<IEnumerable<PatientReg>>(result);
                    }
                }
            }
            return View(patientresult);
        }
        public IActionResult AddPatient()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddPatient(PatientReg patientReg)
        {
            ViewBag.status = "";
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(patientReg), Encoding.UTF8, "application/json");
                string endPoint = _configuration["WebApiBaseUrl"] + "PatientReg/AddPatient";
                using (var response = await client.PostAsync(endPoint, content))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        ViewBag.status = "Ok";
                        ViewBag.message = "Patient details saved successfully!";
                    }
                    else
                    {
                        ViewBag.status = "Error";
                        ViewBag.message = "Wrong entries!";
                    }
                }
            }
            return View();
        }
        public IActionResult GetEmployeeById()
        {
            return View();
        }
        [HttpGet("GetEmployeeById")]
        public async Task<IActionResult> GetEmployeeById(int employeeId)
        {
            ViewBag.status = "";
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(employeeId), Encoding.UTF8, "application/json");
                string endPoint = _configuration["WebApiBaseUrl"] + "Doctor/AddDoctor";
                using (var response = await client.PostAsync(endPoint, content))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        ViewBag.status = "Ok";
                        ViewBag.message = " success!";
                    }
                    else
                    {
                        ViewBag.status = "Error";
                        ViewBag.message = "Wrong entries!";
                    }
                }
            }
            return View();
        }
        public IActionResult GetPatientById()
        {
            return View();
        }
        [HttpGet("GetPatientById")]
        public async Task<IActionResult> GetPatientById(int patientId)
        {
            ViewBag.status = "";
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(patientId), Encoding.UTF8, "application/json");
                string endPoint = _configuration["WebApiBaseUrl"] + "Doctor/AddDoctor";
                using (var response = await client.PostAsync(endPoint, content))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        ViewBag.status = "Ok";
                        ViewBag.message = " success!";
                    }
                    else
                    {
                        ViewBag.status = "Error";
                        ViewBag.message = "Wrong entries!";
                    }
                }
            }
            return View();
        }
    }
}
