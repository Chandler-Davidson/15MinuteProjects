using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Newtonsoft.Json;

namespace WPFWeather
{
    /// <summary>
    /// The base class of the JSON response
    /// </summary>
    class Response
    {
        [JsonProperty("city")]
        public LocationData Location { get; set; }

        private List<WeatherData> _days;

        [JsonProperty("list")]
        public List<WeatherData> Days { get; set; }
    }

    /// <summary>
    /// Defines weather data for either an hour or current data.
    /// </summary>
    public class WeatherData
    {
        [JsonProperty("dt_text")]
        public string DateTimeSTR { get; set; }
        public int Hour { get; set; }
        [JsonProperty("main.temp")]
        public string HourText { get; set; } 
        public int Temperature { get; set; }
        public int TemperatureC => Convert.ToInt32(Temperature - 32 * 0.5556);
        [JsonProperty("weather.main")]
        public string Condition { get; set; }

        [JsonProperty("pressure")]
        public int Percipitation { get; set; }
        [JsonProperty("humidity")]
        public int Humidity { get; set; }
        [JsonProperty("wind.speed")]
        public int Wind { get; set; }
        [JsonProperty("main.description")]
        public string IconPath { get; set; }
    }

    /// <summary>
    /// Defines each day of data.
    /// </summary>
    public class Day : List<WeatherData>
    {
        public string DayName => DateTime.Parse(Hours[0].DateTimeSTR).DayOfWeek.ToString();
        public string DayNameShort => DayName.Substring(0, 3);

        public WeatherData AvgCondition => Hours[0];
        public List<WeatherData> Hours { get; set; }
    }

    public class LocationData
    {
        [JsonProperty("name")]
        public string CityName { get; set; }
        public string StateName { get; set; }
        public string ZipCode { get; set; }

        public WeatherData CurrentWeather { get; set; }
    }
}
