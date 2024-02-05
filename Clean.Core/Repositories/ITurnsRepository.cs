using Clean.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Core.Repositories
{
    public interface ITurnsRepository
    {
        List<turns> GetList();
        turns GetById(int id);
        void Add(turns turn);
        void Update(turns turn, int n);
    }
}

