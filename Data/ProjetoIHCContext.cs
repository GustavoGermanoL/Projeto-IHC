using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoIHC.Models;

namespace ProjetoIHC.Data
{
    public class ProjetoIHCContext : DbContext
    {
        public ProjetoIHCContext (DbContextOptions<ProjetoIHCContext> options)
            : base(options)
        {
        }

        public DbSet<ProjetoIHC.Models.Cliente> Cliente { get; set; } = default!;
    }
}
