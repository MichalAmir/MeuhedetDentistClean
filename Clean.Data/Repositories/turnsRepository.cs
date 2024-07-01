using Clean.Core.Entities;
using Clean.Core.Repositories;
using Microsoft.EntityFrameworkCore;
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
        public async Task AddAsync(turns turn)
        {
            turns new_turn = new turns { NumTurn = turn.NumTurn, IsAvailableTurn = turn.IsAvailableTurn, DateTimeTurn = turn.DateTimeTurn, NumRoom = turn.NumRoom };
            _context.Turns.Add(new_turn);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(turns turn, string NumRoom)
        {
            foreach (turns tun in _context.Turns)
            {
                if (tun.NumRoom.Equals(NumRoom))
                {
                    tun.NumTurn = turn.NumTurn;
                    tun.IsAvailableTurn = turn.IsAvailableTurn;
                    tun.DateTimeTurn = turn.DateTimeTurn;
                    tun.NumRoom = turn.NumRoom;
                    await _context.SaveChangesAsync();
                }

            }
        }
        public async Task RemoveAsync(string NumRoom)
        {
            foreach (var tun in _context.Turns)
            {
                if (tun.NumRoom.Equals(NumRoom))
                {
                    _context.Turns.Remove(tun);
                    await _context.SaveChangesAsync();
                }
            }
        }


    }
}