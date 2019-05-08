using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using cinemaCore.Models;

namespace cinemaCore.Models
{
    public class cinemaCoreContext : DbContext
    {
        public cinemaCoreContext (DbContextOptions<cinemaCoreContext> options)
            : base(options)
        {
        }

        public DbSet<cinemaCore.Models.reserva> reserva { get; set; }

        public DbSet<cinemaCore.Models.sala> sala { get; set; }

        public DbSet<cinemaCore.Models.silla> silla { get; set; }

        public DbSet<cinemaCore.Models.tarjeta> tarjeta { get; set; }
    }
}
