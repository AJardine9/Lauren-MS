using System;
using System.Collections.Generic;
using System.Text;
using PizzaStore.Data.Models;
using PizzaStore.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace PizzaStore.Data 
{
    public class PizzaStoreDbContext : DbContext
    {
        public DbSet<Location> Locations { get; set; }
        public DbSet<Pi>
    }
}
