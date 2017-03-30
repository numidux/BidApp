using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using BidApp.Models;

namespace BidApp.DAL
{
    public class BidAppContext : DbContext
    {
        public BidAppContext() : base("BidAppContext")
        {
        }

        public DbSet<Product> Products { get; set;} 

    }
}