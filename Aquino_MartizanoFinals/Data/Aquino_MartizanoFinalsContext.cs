using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Aquino_MartizanoFinals.Models;

namespace Aquino_MartizanoFinals.Data
{
    public class Aquino_MartizanoFinalsContext : DbContext
    {
        public Aquino_MartizanoFinalsContext (DbContextOptions<Aquino_MartizanoFinalsContext> options)
            : base(options)
        {
        }

        public DbSet<Aquino_MartizanoFinals.Models.User> User { get; set; } = default!;
    }
}
