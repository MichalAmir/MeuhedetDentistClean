using Clean.Core.Entities;
using Clean.Core.Repositories;

namespace Clean.Service
{
    public class doctorsServices
    {
        private readonly IDoctorsRepository _doctorsRepository;
        public doctorsServices(IDoctorsRepository dR)
        {
            _doctorsRepository = dR;
        }
        public List<doctors> GetAll()
        {
            return _doctorsRepository.GetList();
        }
        public doctors GetDoctorById(int id)
        {
            return _doctorsRepository.GetById(id);
        }
        public void AddDoctor(doctors doctor)
        {
            _doctorsRepository.Add(doctor);
        }
        public void UpdateDoctor(doctors doctor, int id)
        {
            _doctorsRepository.Update(doctor, id);
        }
    }
}