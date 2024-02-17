using System.ComponentModel.DataAnnotations;

namespace Clean.Core.Entities
{
    public class clients
    {
        [Key]
        public int IdClient { get; set; }
        public string NameClient { get; set; }
        public int AgeClient { get; set; }
        public string AdressClient { get; set; }
    }
}
