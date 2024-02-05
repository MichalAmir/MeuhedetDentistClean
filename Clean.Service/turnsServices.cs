using Clean.Core.Entities;
using Clean.Core.Repositories;

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
        public turns GetTurnById(int n)
        {
            return _turnsRepository.GetById(n);
        }
        public void AddTurn(turns turn)
        {
            _turnsRepository.Add(turn);
        }
        public void UpdateTurn(turns turn, int n)
        {
            _turnsRepository.Update(turn, n);
        }
    }
}
