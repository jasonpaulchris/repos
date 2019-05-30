﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Http;

namespace SportsStore.Models
{
    public class Order
    {
        [HttpBindNever]
        public int Id { get; set; }
        [Required]
        [HttpBindNever]
        public string Customer { get; set; }
        public decimal TotalCost { get; set; }
        public ICollection<OrderLine> Lines { get; set; }
    }

    public class OrderLine
    {
        [HttpBindNever]
        public int Id { get; set; }
        [Required]
        [Range(0,100)]
        public int Count { get; set; }
        [Required]
        public int ProductId { get; set; }
        [HttpBindNever]
        public int OrderId { get; set; }
        [HttpBindNever]
        public Product Product { get; set; }
        [HttpBindNever]
        public Order Order { get; set; }
    }
}