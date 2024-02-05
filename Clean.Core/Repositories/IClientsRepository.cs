using Clean.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Core.Repositories
{
    public interface IDoctorsRepository
    {
        List<doctors> GetList();
        doctors GetById(int id);
        void Add(doctors doctor);
        void Update(doctors doctor, int id);
    }
}
