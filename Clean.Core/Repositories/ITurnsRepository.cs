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
        turns GetById(string NumRoom);
        Task AddAsync(turns turn);
        Task UpdateAsync(turns turn, string NumRoom);
        Task RemoveAsync(string NumRoom);
    }
}

