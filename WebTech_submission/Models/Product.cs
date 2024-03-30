﻿using System.ComponentModel.DataAnnotations;

namespace WebTech_submission.Models
{
    public class Product
    {
        [Key]

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public decimal ShippingCost { get; set; }
    }
}
