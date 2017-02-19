using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApplication1
{
    class Program
    {

        //The structure of the C# Class
        //{"value":"1000"}
        static void Main(string[] args)
        {
           // var json = new WebClient().DownloadString("https://supercharger-e2f62.firebaseio.com/0.json");
            var json = "";
            var name = "";
            var value = "";
                

            using (WebClient wc = new WebClient())
            {
                json = wc.DownloadString("https://supercharger-e2f62.firebaseio.com/.json");

                //Console.WriteLine(json);

                dynamic results = JsonConvert.DeserializeObject<dynamic>(json);
                
                value = results.value;

            }

            Console.WriteLine(name + value);
            Console.ReadLine();
            
        }
    }

}

//jason structure
//{"value":"1000"}