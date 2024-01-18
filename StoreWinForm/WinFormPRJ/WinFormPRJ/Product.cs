using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormPRJ
{
    public class Product
    {
        public string? Name { get; set; }
        public int Quality { get; set; }
        public double Price { get; set; }
        public string? Description { get; set; }
        public Product()
        {

        }

        public Product(string? name, int quality, double price, string? description)
        {
            Name = name;
            Quality = quality;
            Price = price;
            Description = description;
        }
    }
}
