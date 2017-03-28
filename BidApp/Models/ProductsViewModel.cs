using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BidApp.Models
{
    public class ProductsViewModel
    {
        public IEnumerable<Product> Products { get; set; }
    }
}