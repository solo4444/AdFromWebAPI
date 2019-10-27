using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiCore.Models;

namespace WebApiCore.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        { }
        public DbSet<Item> Items { get; set; }
        public DbSet<WebApiCore.Models.Cart> Cart { get; set; }
    }
}
