using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ModeloDatos.modelo;

namespace LeidyEsMk.Controllers
{
    public class TarjetaController : ApiController
    {
        CineEntities BD = new CineEntities();
        // GET: api/Tarjeta
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Tarjeta/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Tarjeta
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Tarjeta/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Tarjeta/5
        public void Delete(int id)
        {
        }
    }
}
