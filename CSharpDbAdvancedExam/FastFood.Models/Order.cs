using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

namespace FastFood.Models
{
    public class Order
    {
        public Order()
        {
            this.OrderItems = new List<OrderItem>();
        }

        public int Id { get; set; }

        [Required]
        public string Customer { get; set; }

        public DateTime DateTime { get; set; } 

        [Required]
        public OrderType Type { get; set; }

        [Required]
        public decimal TotalPrice { get; }

        public int EmployeeId { get; set; }

        public Employee Employee { get; set; } 

        public ICollection<OrderItem> OrderItems { get; set; }
    }
}