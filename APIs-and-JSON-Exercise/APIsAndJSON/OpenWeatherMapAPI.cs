using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    internal class OpenWeatherMapAPI
    {
        public static void CityWeather()
        {
            
            var apiKeyObj = File.ReadAllText("appsettings.json");

            
            var apiKey = JObject.Parse(apiKeyObj).GetValue("apiKey").ToString();

            
            Console.WriteLine("Enter in the zipcode of the area you want to check:");

            
            var zipcode = Console.ReadLine();

            
            var weatherUrl = $"http://api.openweathermap.org/data/2.5/weather?zip={zipcode}&appid={apiKey}&units=imperial";

            
            HttpClient client = new HttpClient();

            
            var weatherResponse = client.GetStringAsync(weatherUrl).Result;

            
            var weatherObj = JObject.Parse(weatherResponse);

            
            Console.WriteLine($"Temp: {weatherObj["main"]["temp"]} degrees in {zipcode}");

            
        }
    }
}
