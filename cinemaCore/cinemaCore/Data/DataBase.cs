using cinemaCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace cinemaCore.Data
{
    public class DataBase
    {public static void Initialize(cinemaCoreContext context)
        {
            context.Database.EnsureCreated();
            if (context.silla.Any())
            {
                return;
            }
            var sillas = new silla[]
            {
                new silla {idSilla=1,fila=1,noSilla=1,preferencial=true,sillaPaga=false }
            };
            foreach (silla c in sillas)
            {
                context.silla.Add(c);
            }
            context.SaveChanges();
            if (context.sala.Any())
            {
                return;
            }

            var sala = new sala[]
           {
                new sala {noSala=1,ingreso=120000 }
           };
            foreach (sala c in sala)
            {
                context.sala.Add(c);
            }
            context.SaveChanges();
            if (context.tarjeta.Any())
            {
                return;
            }
            var tarjeta = new tarjeta[]
           {
                new tarjeta {idTarjeta=1,docPropietario=1012558696,nombrePropietario="Jorga Peña",recarga=50000,saldo=80000 }
           };
            foreach (tarjeta c in tarjeta)
            {
                context.tarjeta.Add(c);
            }
            context.SaveChanges();
            if (context.reserva.Any())
            {
                return;
            }
            var reservas = new reserva[]
           {
                new reserva {idReserva=1,docSolicitante=1012458552,estadoPago=false,PagoConTarjeta=true,cantidadSillas=2 }
           };
            foreach (reserva c in reservas)
            {
                context.reserva.Add(c);
            }
            context.SaveChanges();
        }
    }
}
