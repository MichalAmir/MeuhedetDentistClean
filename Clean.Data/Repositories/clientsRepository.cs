using Clean.Core.Entities;
using Clean.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Data.Repository
{
    public class clientsRepository : IClientsRepository
    {
        private readonly DataContext _context;
        public clientsRepository(DataContext context)
        {
            _context = context;
            _context.SaveChanges();
        }
        public List<clients> GetList()
        {
            return _context.Clients.ToList();
        }
        public clients GetById(int id)
        {
            foreach (clients client in _context.Clients)
            {
                if (client.IdClient == id)
                    return client;
            }
            return null;
        }
        public void Add(clients client)
        {
            clients new_client = new clients { IdClient = client.IdClient, NameClient = client.NameClient, AgeClient = client.AgeClient, AdressClient = client.AdressClient };
            _context.Clients.Add(new_client);
            _context.SaveChanges();
        }
        public void Update(clients client, int id)
        {
            clients update_client = new clients { IdClient = client.IdClient, NameClient = client.NameClient, AgeClient = client.AgeClient, AdressClient = client.AdressClient };
            foreach (clients clt in _context.Clients)
            {
                if (clt.IdClient == id)
                {
                    clt.IdClient = update_client.IdClient;
                    clt.NameClient = update_client.NameClient;
                    clt.AgeClient = update_client.AgeClient;
                    clt.AdressClient = update_client.AdressClient;
                    _context.SaveChanges();
                }

            }
        }

    }
}