using HMS.DAL.Repository;
using HMS.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.BAL.Services
{
     public class PatientRegServices
    {
        IPatientRegRepository _patientRegRepository;
        public PatientRegServices(IPatientRegRepository patientRegRepository)
        {
            _patientRegRepository = patientRegRepository;
        }
        public void AddPatient(PatientReg patientReg)
        {
            _patientRegRepository.AddPatient(patientReg);
        }
        public void DeletePatient(int PatientId)
        {
            _patientRegRepository.DeletePatient(PatientId);
        }
        public void GetPatientById(int PatientId)
        {
            _patientRegRepository.GetPatientById(PatientId);
        }
        public void UpdatePatient(PatientReg patientReg)
        {
            _patientRegRepository.UpdatePatient(patientReg);
        }


        public IEnumerable<PatientReg> GetPatients()
        {
            return _patientRegRepository.GetPatients();


        }

    }
}
