using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cinemaCore.Models
{
    public class silla
    {[Key,Required] public int idSilla { get; set; }
        [Required] public int fila { get; set; }
        [Required] public int noSilla { get; set; }
        [Required] public Boolean preferencial{ get; set; }
        [Required] public Boolean sillaPaga{ get; set; }


    }
}
