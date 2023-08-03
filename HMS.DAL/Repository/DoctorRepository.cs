using HMS.DAL.Data;
using HMS.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HMS.DAL.Repository
{
    public class DoctorRepository : IDoctorRepository
    {
        HMSDbContext _hMSDbContext;
        public DoctorRepository(HMSDbContext hMSDbContext)
        {
            _hMSDbContext = hMSDbContext;
        }
        public void AddDoctor(Doctor doctor)
        {
            _hMSDbContext.doctor.Add(doctor);
            _hMSDbContext.SaveChanges();
        }

        public void DeleteDoctor(int DoctorId)
        {
            var doctor = _hMSDbContext.doctor.Find(DoctorId);
            _hMSDbContext.doctor.Remove(doctor);
            _hMSDbContext.SaveChanges();

        }


        public Doctor GetDoctorById(int DoctorId)
        {
            return _hMSDbContext.doctor.Find(DoctorId);
        }

        public IEnumerable<Doctor> GetDoctors()
        {
            /* var items = _hMSDbContext.doctor.Where(x => x.ID==doct)

                  .Select(x => new
                  {
                      P1 = table.Prop1,
                      P2 = table.Prop2
                  });*/
            var s = _hMSDbContext.doctor
        .Where(c => c.DoctorId == 1)
        .ToList();
            //return _hMSDbContext.doctor.ToList();
            return s;
        }

        public void UpdateDoctor(Doctor doctor)
        {
            _hMSDbContext.Entry(doctor).State = EntityState.Modified;
            _hMSDbContext.SaveChanges();
        }

        public Doctor Login(Doctor doctor)
        {
            Doctor doctorinfo = null;
            var result = _hMSDbContext.doctor.Where(obj => obj.Email == doctor.Email && obj.Password == doctor.Password).ToList();
            if (result.Count > 0)
            {
                doctorinfo = result[0];
            }
            return doctorinfo;

        }
    }
}
