using System.ComponentModel.DataAnnotations;

namespace Clean.Core.Entities
{
    public class turns
    {
        [Key]
        public string NumTurn { get; set; }
        public Boolean IsAvailableTurn { get; set; }
        public DateTime DateTimeTurn { get; set; }
        public int NumRoom { get; set; }
    }
}
