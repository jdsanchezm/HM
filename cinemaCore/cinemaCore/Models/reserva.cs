using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cinemaCore.Models
{
    public class reserva
    {[Key, Required] public int idReserva { get; set; }
        [Required] public int docSolicitante { get; set; }
        [Required] public Boolean estadoPago { get; set; }
        [Required] public Boolean PagoConTarjeta { get; set; }
        [Required] public int cantidadSillas { get; set; }


    }
}
