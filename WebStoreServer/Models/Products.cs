using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebStoreServer.Models
{
    public class Products
    {
        public int Id { get; set; }
        [DataType(DataType.Text)]
        public string Name { get; set; }
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public DateTime DataInserted { get; set; } = DateTime.Now;
        public virtual List<Image> Images { get; set; }
    }
}