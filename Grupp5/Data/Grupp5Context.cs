using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Grupp5.Models;

namespace Grupp5.Data
{
    public class Grupp5Context : DbContext
    {
        public Grupp5Context (DbContextOptions<Grupp5Context> options)
            : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }
    }
}
