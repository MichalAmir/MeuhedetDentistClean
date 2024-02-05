using Clean.Core.Entities;
using Clean.Core.Repositories;
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
            return _context.Doctors;
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
        public void Add(doctors doctor)
        {
            doctors new_doctor = new doctors { IdDoctors = doctor.IdDoctors, NameDoctors = doctor.NameDoctors, SalaryDoctors = doctor.SalaryDoctors, HoursDoctors = doctor.HoursDoctors };
            _context.Doctors.Add(new_doctor);
        }
        public void Update(doctors doctor, int id)
        {
            doctors update_doctor = new doctors { IdDoctors = doctor.IdDoctors, NameDoctors = doctor.NameDoctors, SalaryDoctors = doctor.SalaryDoctors, HoursDoctors = doctor.HoursDoctors };
            foreach (doctors dor in _context.Doctors)
            {
                if (dor.IdDoctors == id)
                {
                    dor.IdDoctors = update_doctor.IdDoctors;
                    dor.NameDoctors = update_doctor.NameDoctors;
                    dor.SalaryDoctors = update_doctor.SalaryDoctors;
                    dor.HoursDoctors = update_doctor.HoursDoctors;
                }

            }
        }

    }
}