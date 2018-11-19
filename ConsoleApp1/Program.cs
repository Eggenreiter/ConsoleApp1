using RestSharp;
using RestSharp.Authenticators;
using System;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {

            var client = new RestClient("http://10.0.0.3/api/printer/tool");
            var request = new RestRequest(Method.GET);
            //request.AddHeader("Postman-Token", "db280712-d9b2-4de3-af4a-0fadf7e86061");
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("x-api-key", "60F33BE1DB34464789BF6D16F2EA1769");
            IRestResponse response = client.Execute(request);

            IRestResponse<Tool0> response2 = client.Execute<Tool0>(request);
            double actual = response2.Data.actual;
            int offset = response2.Data.offset;
            int target = response2.Data.target;

            Console.WriteLine(actual);
            Console.WriteLine(offset);
            Console.WriteLine(target);
            Console.WriteLine(response2);






        }
    }

}
