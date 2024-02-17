using Clean.Core.Entities;
using Clean.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Clean.Service
{
    public class turnsServices
    {
        private readonly ITurnsRepository _turnsRepository;
        public turnsServices(ITurnsRepository tR)
        {
            _turnsRepository = tR;
        }
        public List<turns> GetAll()
        {
            return _turnsRepository.GetList();
        }
        public turns GetTurnById(string NumRoom)
        {
            return _turnsRepository.GetById(NumRoom);
        }
        public void AddTurn(turns turn)
        {
            _turnsRepository.Add(turn);
        }
        public void UpdateTurn(turns turn, string NumRoom)
        {
            _turnsRepository.Update(turn, NumRoom);
        }
        public void DeleteTurn(string NumRoom)
        {
            _turnsRepository.Remove(NumRoom);
        }
    }
}
