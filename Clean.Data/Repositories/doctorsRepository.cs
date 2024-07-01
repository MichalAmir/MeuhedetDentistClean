using Clean.Core.Entities;
using Clean.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Data.Repository
{
    public class doctorsRepository : IDoctorsRepository
    {
        private readonly DataContext _context;
        public doctorsRepository(DataContext context)
        {
            _context = context;
        }
        public List<doctors> GetList()
        {
            return _context.Doctors.ToList();
        }
        public doctors GetById(int id)
        {
            foreach (doctors doctor in _context.Doctors)
            {
                if (doctor.IdDoctors == id)
                    return doctor;
            }
            return null;
        }
        public async Task AddAsync(doctors doctor)
        {
            doctors new_doctor = new doctors { IdDoctors = doctor.IdDoctors, NameDoctors = doctor.NameDoctors, SalaryDoctors = doctor.SalaryDoctors, HoursDoctors = doctor.HoursDoctors };
            _context.Doctors.Add(new_doctor);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(doctors doctor, int id)
        {
            foreach (doctors dor in _context.Doctors)
            {
                if (dor.IdDoctors.Equals(id))
                {
                    dor.IdDoctors = dor.IdDoctors;
                    dor.NameDoctors = dor.NameDoctors;
                    dor.SalaryDoctors = dor.SalaryDoctors;
                    dor.HoursDoctors = dor.HoursDoctors;
                    await _context.SaveChangesAsync();
                }

            }
        }
        public async Task RemoveAsync(int id)
        {
            foreach (var dor in _context.Doctors)
            {
                if (dor.IdDoctors.Equals(id))
                {
                    _context.Doctors.Remove(dor);
                    await _context.SaveChangesAsync();
                }
            }

        }
    }
}