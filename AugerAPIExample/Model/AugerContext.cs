using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AugerAPIExample.Model
{
    public class AugerContext : DbContext
    {
        public AugerContext(DbContextOptions<AugerContext> options)
            : base(options)
        {
        }
        public DbSet<AugerTable> HubItems { get; set; }
    }
}
