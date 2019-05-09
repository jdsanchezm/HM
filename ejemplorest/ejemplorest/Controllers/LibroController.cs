using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ejemplorest.Models;

namespace ejemplorest.Controllers
{
    public class LibroController : ApiController
    {
        // GET: api/Libro
        public IEnumerable<Libro> Get()
        {
            var ListaLibros = new List<Libro>();
            {
                var harry = new Libro()
                {
                    idLibro = 1,
                    autor="JK Rowling",
                    titulo="Harry Potter"
               
                };
                ListaLibros.Add(harry);
                var dracula = new Libro()
                {
                    idLibro = 2,
                    autor = "Bram Stoker",
                    titulo = "Dracula"

                };
                ListaLibros.Add(dracula);

                var bienymal = new Libro()
                {
                    idLibro = 3,
                    autor = "Fridrich Nietzsche",
                    titulo = "Entre el bien y el mal"

                };
                ListaLibros.Add(dracula);
            };
            return ListaLibros;
        }

        // GET: api/Libro/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Libro
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Libro/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Libro/5
        public void Delete(int id)
        {
        }
    }
}
