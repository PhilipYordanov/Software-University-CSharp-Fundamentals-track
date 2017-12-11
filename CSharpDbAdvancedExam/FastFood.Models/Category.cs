using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace FastFood.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        public string Name { get; set; }

        public ICollection<Item> Items { get; set; }
        
    }
}