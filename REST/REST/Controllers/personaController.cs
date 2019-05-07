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
        // GET: api/persona
        public IEnumerable<personainfo> Get()
        {
            var ListaInfoPersona = new List<personainfo>();
        
            {
               var personainfo = new personainfo
                {
                    NoDocumento = 1000557888,
                    nombre = $"Jorge Peña",
                    edad = 40,
                    ocupacion = $"Abogado",
                };
                ListaInfoPersona.Add(personainfo);
            }
            return ListaInfoPersona;
        }

        // GET: api/persona/5
        public personainfo Get(int id)
        {
            return  new personainfo
            {
                NoDocumento = id,
                nombre = $"nombre",
                edad = edad,
                ocupacion = $"ocupacion",
            };
            

        }

        // POST: api/persona
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/persona/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/persona/5
        public void Delete(int id)
        {
        }
    }
}
