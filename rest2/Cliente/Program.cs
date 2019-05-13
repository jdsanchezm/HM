using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
//using Newtonsoft.Json;

namespace Cliente
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient cliente = new HttpClient();
            cliente.BaseAddress = new Uri("http://localhost:42845/");
            var request = cliente.GetAsync("api/libro").Result;
            //string url = "localhost:42845/api/libro";
            //var json = new WebClient().DownloadString(url);
            // dynamic m = JsonConvert.DeserializeObject(json);
            //  Console.WriteLine(json);
        }
    }
}
