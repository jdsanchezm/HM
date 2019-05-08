using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cinemaCore.Models
{
    public class sala
    {[Key,Required]public int noSala { get; set; }
      [Required] public int ingreso { get; set; }
    }
}
