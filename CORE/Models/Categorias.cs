using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CORE.Models
{
    public class Categorias
    {[Key]
        public int IdCategoria { get; set; }
        [Required]
        [StringLength (50,MinimumLength = 10, ErrorMessage ="El nombre debe estar entre 50 y 10 caracteres")]
        
        public string Nombre { get; set; }
    
        
        public string Descripcion { get; set; }
    }
}
