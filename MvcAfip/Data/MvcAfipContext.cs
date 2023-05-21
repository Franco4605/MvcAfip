using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcAfip.Models;

namespace MvcAfip.Data
{
    public class MvcAfipContext : DbContext
    {
        public MvcAfipContext (DbContextOptions<MvcAfipContext> options)
            : base(options)
        {
        }

        public DbSet<MvcAfip.Models.Afip> Afip { get; set; } = default!;
    }
}
