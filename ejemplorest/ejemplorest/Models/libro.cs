using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ejemplorest.Models
{
    public class Libro
    {
        public int idLibro { get; set; }
        public string titulo { get; set; }
        public string autor { get; set; }
    }
}