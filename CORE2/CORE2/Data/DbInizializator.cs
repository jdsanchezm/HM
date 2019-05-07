using CORE2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CORE2.Data
{
    public class DbInizializator
    {
        public static void Initialize(CORE2Context context)
        {
            context.Database.EnsureCreated();
            if (context.Categoria.Any())
            {
                return;
            }
            var Categoria = new Categoria[]{
                new Categoria{Nombre="EStilo",Descripcion="Evalua tu estilo" },
                 new Categoria{Nombre="fuerza",Descripcion="Evalua tu fuerza" }
            };
            foreach(Categoria c in Categoria)
            {
                context.Categoria.Add(c);
            }
            context.SaveChanges();
        }

    }
}
