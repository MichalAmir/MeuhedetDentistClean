using Clean.Core.Entities;
using Clean.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Data.Repository
{
    public class turnsRepository : ITurnsRepository
    {
        private readonly DataContext _context;
        public turnsRepository(DataContext context)
        {
            _context = context;
        }
        public List<turns> GetList()
        {
            return _context.Turns;
        }
        public turns GetById(int n)
        {
            foreach (turns turn in _context.Turns)
            {
                if (turn.NumTurn == n)
                    return turn;
            }
            return null;
        }
        public void Add(turns turn)
        {
            turns new_turn = new turns { NumTurn = turn.NumTurn, IsAvailableTurn = turn.IsAvailableTurn, DateTimeTurn = turn.DateTimeTurn, NumRoom = turn.NumRoom };
            _context.Turns.Add(new_turn);
        }
        public void Update(turns turn, int n)
        {
            turns update_turn = new turns { NumTurn = turn.NumTurn, IsAvailableTurn = turn.IsAvailableTurn, DateTimeTurn = turn.DateTimeTurn, NumRoom = turn.NumRoom };
            foreach (turns tun in _context.Turns)
            {
                if (tun.NumTurn == n)
                {
                    tun.NumTurn = update_turn.NumTurn;
                    tun.IsAvailableTurn = update_turn.IsAvailableTurn;
                    tun.DateTimeTurn = update_turn.DateTimeTurn;
                    tun.NumRoom = update_turn.NumRoom;
                }

            }
        }

    }
}