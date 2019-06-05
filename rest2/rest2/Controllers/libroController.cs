using rest2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace rest2.Controllers
{
    public class libroController : ApiController
    {
        List<Libro>  ListaLibros = new List<Libro>(); 

        //Como no tenemos BBDD, declaramos en el constructor las personas que estarían en //nuestra BBDD

        public libroController()       
      
            {
                Libro harry = new Libro
                {
                    idLibro = 1,
                    titulo = "Harry Potter",
                    autor = "JK Rowlling",
                };
                this.ListaLibros.Add(harry);

               Libro  dracula = new Libro
                {
                    idLibro = 2,
                    titulo = "Dracula",
                    autor = "Bram Stoker",
                };
                this.ListaLibros.Add(dracula);
            Libro bienymal = new Libro
            {
                idLibro = 3,
                titulo = "Mas allá del bien y el mal",
                autor = "Friedrich Nietzsche",
            };
            this.ListaLibros.Add(bienymal);
        }
    // GET: api/libro
    public IEnumerable<Libro> GetLibros()
        {

            return this.ListaLibros;
        }

        // GET: api/libro/5
        public Libro GetLibro(int id)
        {
         Libro libro = this.ListaLibros.Find(x => x.idLibro == id);
           
            return libro;
            
        }

        // POST: api/libro
        public void Post([FromBody]Libro value)
        {
        }

        // PUT: api/libro/5
        public void Put(int id, [FromBody]Libro value)
        {
        }

        // DELETE: api/libro/5
        public void Delete(int id)
        {
        }
    }
}
