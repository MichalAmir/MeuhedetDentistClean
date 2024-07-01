using Clean.Core.Entities;
using Clean.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Service
{
    public class clientsServices
    {
        private readonly IClientsRepository _clientsRepository;
        public clientsServices(IClientsRepository cR)
        {
            _clientsRepository = cR;
        }
        public List<clients> GetAll()
        {
            return _clientsRepository.GetList();
        }
        public clients GetClientById(int id)
        {
            return _clientsRepository.GetById(id);
        }
        public async Task AddClientAsync(clients client)
        {
            await _clientsRepository.AddAsync(client);
        }
    }
}