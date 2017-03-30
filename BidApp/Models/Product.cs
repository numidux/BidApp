using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BidApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }


        public Product()
        {

        }
        public Product(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }
}