using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CORE.Models;

namespace CORE.Data
{
    public class DataBaseInicializador
    {
        public static void Initialize(COREContext context)
        {
            context.Database.EnsureCreated();
            if (context.Categorias.Any())
            {
                return;
            }
            var categorias = new Categorias[]
            {
new Categorias {Nombre="Desfile",Descripcion="Prueba fisica"  },
new Categorias {Nombre="Belleza",Descripcion="Evalua Belleza "  }
            };
            foreach(Categorias c in categorias)
            {
                context.Categorias.Add(c);
            }
            context.SaveChanges();
        }
    }
}
