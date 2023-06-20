using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;




namespace KanyePi
{  
    class Program
    { 
        public static string Main(string[] args)
        {
            var client = new HttpClient();
            string kanyeURL = null;
            var KanyeResponse = client.GetStringAsync(kanyeURL).Result;
            var kanyeQuote = JObject.Parse(KanyeResponse).GetValue("quote").ToString();
            return kanyeQuote;
        }
    }
}

