using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmilyChrisSalesAPI.Models;

namespace EmilyChrisSalesAPI.Data
{
    public class EmilyChrisSalesAPIContext : DbContext
    {
        public EmilyChrisSalesAPIContext (DbContextOptions<EmilyChrisSalesAPIContext> options)
            : base(options)
        {
        }

        public DbSet<EmilyChrisSalesAPI.Models.Customer> Customers { get; set; } = default!;
        public DbSet<EmilyChrisSalesAPI.Models.Order> Orders { get; set; } = default!;
    }
}
