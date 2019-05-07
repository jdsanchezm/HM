using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CORE2.Models
{
    public class CORE2Context : DbContext
    {
        public CORE2Context (DbContextOptions<CORE2Context> options)
            : base(options)
        {
        }

        public DbSet<CORE2.Models.Categoria> Categoria { get; set; }
    }
}
