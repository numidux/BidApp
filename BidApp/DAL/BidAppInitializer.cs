using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BidApp.Models;

namespace BidApp.DAL
{
    public class BidAppInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<BidAppContext>
    {
        protected override void Seed(BidAppContext context)
        {
            var firstProduct = new Product(1, "PES 2017", 20);
            var secondProduct = new Product(2, "FIFA 17", 22);

            var products = new List<Product>();
            products.Add(firstProduct);
            products.Add(secondProduct);

            products.ForEach(e => context.Products.Add(e));
            context.SaveChanges();
        }
    }
}