using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Cliente
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient cliente = new HttpClient();
            cliente.BaseAddress = new Uri("http://localhost:42845/");
            var request = cliente.GetAsync("api/libro").Result;
            var resultRequest = request.Content.ReadAsStringAsync.;
            var json = new WebClient().DownloadString(request);
             dynamic m = JsonConvert.DeserializeObject(json);
             Console.WriteLine(json);
            Console.ReadLine();
        }
    }
}
