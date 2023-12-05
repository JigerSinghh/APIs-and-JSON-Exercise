using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    internal class RonVSKanyeAPI
    {

        public static void KanyeQuote()
        {
            string KanyeUr1 = "https://api.kanye.rest";

            HttpClient client = new HttpClient();

            string KanyeResponse = client.GetStringAsync(KanyeUr1).Result;

            JObject kanyeObject = JObject.Parse(KanyeResponse);
            Console.WriteLine($"Kanye: {kanyeObject["quote"]}");

        }

        public static void RonQuotes()
        {
            string RonUr1 = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            HttpClient client = new HttpClient();

            var ronResponse = client.GetStringAsync(RonUr1).Result;

            var ronQuote = JArray.Parse(ronResponse);

            Console.WriteLine($"Ron: {ronQuote[0]}");
            Console.WriteLine();
        }

        public static void Convo()
        {
            for (int i = 9; i < +15; i++)
            {
                KanyeQuote();
                RonQuotes();
            }
        }


    } 
}
