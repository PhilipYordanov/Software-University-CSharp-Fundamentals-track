using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace FastFood.Models
{
    public class Employee
    {
        public Employee()
        {
            this.Position = new Position();
        }

        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required]
        [Range(15,80)]
        public int Age { get; set; }

        public int PositionId { get; set; }

        [Required]
        public Position Position { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}