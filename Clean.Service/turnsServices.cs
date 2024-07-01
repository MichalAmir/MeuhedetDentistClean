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
        public async Task AddTurnAsync(turns turn)
        {
            await _turnsRepository.AddAsync(turn);
        }
        public async Task UpdateTurnAsync(turns turn, string NumRoom)
        {
            await _turnsRepository.UpdateAsync(turn, NumRoom);
        }
        public async Task DeleteTurnAsync(string NumRoom)
        {
            await _turnsRepository.RemoveAsync(NumRoom);
        }
    }
}
