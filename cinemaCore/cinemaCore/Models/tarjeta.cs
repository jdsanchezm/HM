using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cinemaCore.Models
{
    public class tarjeta
    {[Key,Required]public int idTarjeta { get; set; }
        [Required] public int docPropietario { get; set; }
        [Required] public string nombrePropietario { get; set; }
        [Required] public int saldo { get; set; }
        [Required] public int recarga{ get; set; }
}
}
