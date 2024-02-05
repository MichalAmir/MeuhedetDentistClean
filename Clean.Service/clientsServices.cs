using Clean.Core.Entities;
using Clean.Core.Repositories;

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
        public void AddClient(clients client)
        {
            _clientsRepository.Add(client);
        }
        public void UpdateClient(clients client, int id)
        {
            _clientsRepository.Update(client, id);
        }
    }
}