using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Model;

namespace Data
{
    public class PizzaContext : DbContext
    {
        public DbSet<CustomerOrder> customerOrders { get; set; }
        public DbSet<Pizza> pizzaOrders { get; set; }
        public PizzaContext([NotNullAttribute] DbContextOptions options) : base(options)
        {

        }
        
    }
}
