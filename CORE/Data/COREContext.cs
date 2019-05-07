using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CORE.Models
{
    public class COREContext : DbContext
    {
        public COREContext (DbContextOptions<COREContext> options)
            : base(options)
        {
        }

        public DbSet<CORE.Models.Categorias> Categorias { get; set; }
    }
}
