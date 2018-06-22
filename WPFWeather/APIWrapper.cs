using GetWeather;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WPFWeather
{
    static class APIWrapper
    {
        private static WebClient Client = new WebClient();
        private static readonly string appID = "49f7841c12274550a57cc63dd69172c1";
        private static string url;

        public static Response GetData(string location)
        {
            url = $"http://api.openweathermap.org/data/2.5/forecast?q={location},us&appid={appID}";

            var jsonData = Client.DownloadString(url);

            return Response.FromJson(jsonData);
        }
    }
}
