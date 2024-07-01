using Clean.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Core.Repositories
{
    public interface IClientsRepository
    {
        List<clients> GetList();
        clients GetById(int id);
        Task AddAsync(clients client);
        Task UpdateAsync(clients client, int id);
    }
}
