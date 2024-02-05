using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Core.Entities
{
    public class turns
    {
        public int NumTurn { get; set; }
        public Boolean IsAvailableTurn { get; set; }
        public DateTime DateTimeTurn { get; set; }
        public int NumRoom { get; set; }
    }
}
