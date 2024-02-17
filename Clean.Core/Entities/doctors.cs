using System.ComponentModel.DataAnnotations;

namespace Clean.Core.Entities
{
    public class doctors
    {
        [Key]
        public int IdDoctors { get; set; }
        public string NameDoctors { get; set; }
        public int SalaryDoctors { get; set; }
        public int HoursDoctors { get; set; }
    }
}
