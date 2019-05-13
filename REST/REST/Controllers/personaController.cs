using REST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace REST.Controllers
{
    public class personaController : ApiController
    {
        // GET: api/persona(Es decir, todas las personas registradas)
        [HttpGet]
        public IEnumerable<personainfo> Get()
        {
            var ListaInfoPersona = new List<personainfo>();
        
            {
                var personainfo = new personainfo
                { idPersona = 1,
                    NoDocumento = 1000557888,
                    nombre = "Jorge Peña",
                    edad = 40,
                    ocupacion = "Abogado",
                    
                };
                ListaInfoPersona.Add(personainfo);
            }
            return ListaInfoPersona;
        }
        [HttpGet]
        // GET: api/persona/5(Buscar una persona en especifico)
        public personainfo Get(int id)
        {
            var libro =  BD.personainfo.FirstOrDefault(x=> x.idLibro==id);

          
            return libro;

        }

        // POST: api/persona(Insertar valores)
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/persona/5(Actualizar datos)
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/persona/5(Borrar una persona)
        public void Delete(int id)
        {
        }
    }
}
