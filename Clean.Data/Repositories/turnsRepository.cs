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
            _context.SaveChanges();
        }
        public List<turns> GetList()
        {
            return _context.Turns.ToList();
        }
        public turns GetById(string NumRoom)
        {
            foreach (turns turn in _context.Turns)
            {
                if (turn.NumTurn == NumRoom)
                    return turn;
            }
            return null;
        }
        public void Add(turns turn)
        {
            turns new_turn = new turns { NumTurn = turn.NumTurn, IsAvailableTurn = turn.IsAvailableTurn, DateTimeTurn = turn.DateTimeTurn, NumRoom = turn.NumRoom };
            _context.Turns.Add(new_turn);
            _context.SaveChanges();
        }
        public void Update(turns turn, string NumRoom)
        {
            foreach (turns tun in _context.Turns)
            {
                if (tun.NumRoom.Equals(NumRoom))
                {
                    tun.NumTurn = turn.NumTurn;
                    tun.IsAvailableTurn = turn.IsAvailableTurn;
                    tun.DateTimeTurn = turn.DateTimeTurn;
                    tun.NumRoom = turn.NumRoom;
                    _context.SaveChanges();
                }

            }
        }
        public void Remove(string NumRoom)
        {
            foreach (var numR in _context.Turns)
            {
                if (numR.NumRoom.Equals(NumRoom))
                {
                    _context.Turns.Remove(numR);
                    _context.SaveChanges();
                }
            }
        }

    }
}