using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ClientWebApi
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var client = new HttpClient();
            var result =  client.GetAsync("http://localhost:59280/api/helpdesk/test").Result;
            var applications = result.Content.ReadAsAsync<List<string>>().Result;
            foreach (var item in applications)
            {
                Console.WriteLine(item);

            }
            Console.ReadKey();

        }
    }
}
