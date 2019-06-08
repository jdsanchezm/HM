using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using rest2.Models;

namespace Cliente
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient cliente = new HttpClient();
            cliente.BaseAddress = new Uri("http://localhost:42845/");
            var request = cliente.GetAsync("api/libro").Result;
            if (request.IsSuccessStatusCode)
            {
                var resultstring = request.Content.ReadAsStringAsync().Result;
              var listado = JsonConvert.DeserializeObject<List<Libro>>(resultstring);

                foreach (var item in listado)
               {
                 Console.WriteLine(item.idLibro);
                    Console.WriteLine(item.autor);
                    Console.WriteLine(item.titulo);
                }
               
            }
            Console.ReadLine();
           
        }
    }
}
