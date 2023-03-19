using System.ComponentModel.DataAnnotations;

namespace AutoMapperSample.Entity
{
    public class Employee
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
    }
}
