using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WPFWeather
{
    /// <summary>
    /// Defines weather data for either an hour or current data.
    /// </summary>
    public class WeatherData
    {
        public int Hour { get; set; }
        public int Temperature { get; set; }
        public int TemperatureC => Convert.ToInt32(Temperature - 32 * 0.5556);
        public string Condition { get; set; }

        public int Percipitation { get; set; }
        public int Humidity { get; set; }
        public int Wind { get; set; }
        public string IconPath { get; set; }
    }

    /// <summary>
    /// Defines each day of data.
    /// </summary>
    public class Day : List<WeatherData>
    {
        public string DayName { get; set; }
        public string DayNameShort => DayName.Substring(0, 3);

        public WeatherData AvgCondition { get; set; }
        public List<WeatherData> Hours { get; set; }
    }

    /// <summary>
    /// Defines the current location info.
    /// </summary>
    public class LocationData
    {
        public string CityName { get; set; }
        public string StateName { get; set; }
        public string ZipCode { get; set; }
        public WeatherData CurrentWeather { get; set; }
    }
}
