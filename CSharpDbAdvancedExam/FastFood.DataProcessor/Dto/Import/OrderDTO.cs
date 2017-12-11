using FastFood.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace FastFood.DataProcessor.Dto.Import
{
    [XmlType("Order")]
    public class OrderDTO
    {
        [Required]
        public string Customer { get; set; }

        public string DateTime { get; set; }

        [Required]
        public OrderType Type { get; set; } 

        public string Employee { get; set; }
       
        [XmlArray("Items")]
        [XmlArrayItem("Item", typeof(OrderItemDTO))]
        public OrderItemDTO[] Item { get; set; }
    }
}
