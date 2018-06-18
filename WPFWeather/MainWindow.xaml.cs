using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFWeather
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public LocationData Location { get; set; }
        public List<Day> DayDetails { get; set; }

        public MainWindow()
        {
            /// Define some data
            Location = new LocationData
            {
                CityName = "Huntsville",
                StateName = "AL",
                ZipCode = "35801",
                CurrentWeather = new WeatherData
                {
                    Hour = 1,
                    Temperature = 95,
                    Condition = "Mostly Sunny",
                    Percipitation = 0,
                    Humidity = 51,
                    Wind = 5,
                    IconPath = "../Media/mostly sunny.png"
                }
            };
            DayDetails = new List<Day>
            {
                new Day
                {
                    DayName = "Monday",
                    AvgCondition = Location.CurrentWeather,
                    Hours = new List<WeatherData>
                    {
                        new WeatherData
                        {
                            Hour = 1,
                            Temperature = 75,
                            Condition = "Clear",

                            Percipitation = 0,
                            Humidity = 53,
                            Wind = 1,
                            IconPath = "../Media/mostly sunny.png"
                        },
                        new WeatherData
                        {
                            Hour = 1,
                            Temperature = 75,
                            Condition = "Clear",

                            Percipitation = 0,
                            Humidity = 53,
                            Wind = 1,
                            IconPath = "../Media/mostly sunny.png"
                        },
                        new WeatherData
                        {
                            Hour = 1,
                            Temperature = 75,
                            Condition = "Clear",

                            Percipitation = 0,
                            Humidity = 53,
                            Wind = 1,
                            IconPath = "../Media/mostly sunny.png"
                        },
                        new WeatherData
                        {
                            Hour = 1,
                            Temperature = 75,
                            Condition = "Clear",

                            Percipitation = 0,
                            Humidity = 53,
                            Wind = 1,
                            IconPath = "../Media/mostly sunny.png"
                        },
                        new WeatherData
                        {
                            Hour = 1,
                            Temperature = 75,
                            Condition = "Clear",

                            Percipitation = 0,
                            Humidity = 53,
                            Wind = 1,
                            IconPath = "../Media/mostly sunny.png"
                        },
                        new WeatherData
                        {
                            Hour = 1,
                            Temperature = 75,
                            Condition = "Clear",

                            Percipitation = 0,
                            Humidity = 53,
                            Wind = 1,
                            IconPath = "../Media/mostly sunny.png"
                        },
                        new WeatherData
                        {
                            Hour = 1,
                            Temperature = 75,
                            Condition = "Clear",

                            Percipitation = 0,
                            Humidity = 53,
                            Wind = 1,
                            IconPath = "../Media/mostly sunny.png"
                        },
                    }
                },
                new Day
                {
                    DayName = "Monday",
                    AvgCondition = Location.CurrentWeather,
                    Hours = new List<WeatherData>
                    {
                        new WeatherData
                        {
                            Hour = 1,
                            Temperature = 75,
                            Condition = "Clear",

                            Percipitation = 0,
                            Humidity = 53,
                            Wind = 1,
                            IconPath = "../Media/mostly sunny.png"
                        },
                        new WeatherData
                        {
                            Hour = 1,
                            Temperature = 75,
                            Condition = "Clear",

                            Percipitation = 0,
                            Humidity = 53,
                            Wind = 1,
                            IconPath = "../Media/mostly sunny.png"
                        },
                        new WeatherData
                        {
                            Hour = 1,
                            Temperature = 75,
                            Condition = "Clear",

                            Percipitation = 0,
                            Humidity = 53,
                            Wind = 1,
                            IconPath = "../Media/mostly sunny.png"
                        },
                        new WeatherData
                        {
                            Hour = 1,
                            Temperature = 75,
                            Condition = "Clear",

                            Percipitation = 0,
                            Humidity = 53,
                            Wind = 1,
                            IconPath = "../Media/mostly sunny.png"
                        },
                        new WeatherData
                        {
                            Hour = 1,
                            Temperature = 75,
                            Condition = "Clear",

                            Percipitation = 0,
                            Humidity = 53,
                            Wind = 1,
                            IconPath = "../Media/mostly sunny.png"
                        },
                        new WeatherData
                        {
                            Hour = 1,
                            Temperature = 75,
                            Condition = "Clear",

                            Percipitation = 0,
                            Humidity = 53,
                            Wind = 1,
                            IconPath = "../Media/mostly sunny.png"
                        },
                        new WeatherData
                        {
                            Hour = 1,
                            Temperature = 75,
                            Condition = "Clear",

                            Percipitation = 0,
                            Humidity = 53,
                            Wind = 1,
                            IconPath = "../Media/mostly sunny.png"
                        },
                    }
                },
                new Day
                {
                    DayName = "Monday",
                    AvgCondition = Location.CurrentWeather,
                    Hours = new List<WeatherData>
                    {
                        new WeatherData
                        {
                            Hour = 1,
                            Temperature = 75,
                            Condition = "Clear",

                            Percipitation = 0,
                            Humidity = 53,
                            Wind = 1,
                            IconPath = "../Media/mostly sunny.png"
                        },
                        new WeatherData
                        {
                            Hour = 1,
                            Temperature = 75,
                            Condition = "Clear",

                            Percipitation = 0,
                            Humidity = 53,
                            Wind = 1,
                            IconPath = "../Media/mostly sunny.png"
                        },
                        new WeatherData
                        {
                            Hour = 1,
                            Temperature = 75,
                            Condition = "Clear",

                            Percipitation = 0,
                            Humidity = 53,
                            Wind = 1,
                            IconPath = "../Media/mostly sunny.png"
                        },
                        new WeatherData
                        {
                            Hour = 1,
                            Temperature = 75,
                            Condition = "Clear",

                            Percipitation = 0,
                            Humidity = 53,
                            Wind = 1,
                            IconPath = "../Media/mostly sunny.png"
                        },
                        new WeatherData
                        {
                            Hour = 1,
                            Temperature = 75,
                            Condition = "Clear",

                            Percipitation = 0,
                            Humidity = 53,
                            Wind = 1,
                            IconPath = "../Media/mostly sunny.png"
                        },
                        new WeatherData
                        {
                            Hour = 1,
                            Temperature = 75,
                            Condition = "Clear",

                            Percipitation = 0,
                            Humidity = 53,
                            Wind = 1,
                            IconPath = "../Media/mostly sunny.png"
                        },
                        new WeatherData
                        {
                            Hour = 1,
                            Temperature = 75,
                            Condition = "Clear",

                            Percipitation = 0,
                            Humidity = 53,
                            Wind = 1,
                            IconPath = "../Media/mostly sunny.png"
                        },
                    }
                },
                new Day
                {
                    DayName = "Monday",
                    AvgCondition = Location.CurrentWeather,
                    Hours = new List<WeatherData>
                    {
                        new WeatherData
                        {
                            Hour = 1,
                            Temperature = 75,
                            Condition = "Clear",

                            Percipitation = 0,
                            Humidity = 53,
                            Wind = 1,
                            IconPath = "../Media/mostly sunny.png"
                        },
                        new WeatherData
                        {
                            Hour = 1,
                            Temperature = 75,
                            Condition = "Clear",

                            Percipitation = 0,
                            Humidity = 53,
                            Wind = 1,
                            IconPath = "../Media/mostly sunny.png"
                        },
                        new WeatherData
                        {
                            Hour = 1,
                            Temperature = 75,
                            Condition = "Clear",

                            Percipitation = 0,
                            Humidity = 53,
                            Wind = 1,
                            IconPath = "../Media/mostly sunny.png"
                        },
                        new WeatherData
                        {
                            Hour = 1,
                            Temperature = 75,
                            Condition = "Clear",

                            Percipitation = 0,
                            Humidity = 53,
                            Wind = 1,
                            IconPath = "../Media/mostly sunny.png"
                        },
                        new WeatherData
                        {
                            Hour = 1,
                            Temperature = 75,
                            Condition = "Clear",

                            Percipitation = 0,
                            Humidity = 53,
                            Wind = 1,
                            IconPath = "../Media/mostly sunny.png"
                        },
                        new WeatherData
                        {
                            Hour = 1,
                            Temperature = 75,
                            Condition = "Clear",

                            Percipitation = 0,
                            Humidity = 53,
                            Wind = 1,
                            IconPath = "../Media/mostly sunny.png"
                        },
                        new WeatherData
                        {
                            Hour = 1,
                            Temperature = 75,
                            Condition = "Clear",

                            Percipitation = 0,
                            Humidity = 53,
                            Wind = 1,
                            IconPath = "../Media/mostly sunny.png"
                        },
                    }
                },
                new Day
                {
                    DayName = "Monday",
                    AvgCondition = Location.CurrentWeather,
                    Hours = new List<WeatherData>
                    {
                        new WeatherData
                        {
                            Hour = 1,
                            Temperature = 75,
                            Condition = "Clear",

                            Percipitation = 0,
                            Humidity = 53,
                            Wind = 1,
                            IconPath = "../Media/mostly sunny.png"
                        },
                        new WeatherData
                        {
                            Hour = 1,
                            Temperature = 75,
                            Condition = "Clear",

                            Percipitation = 0,
                            Humidity = 53,
                            Wind = 1,
                            IconPath = "../Media/mostly sunny.png"
                        },
                        new WeatherData
                        {
                            Hour = 1,
                            Temperature = 75,
                            Condition = "Clear",

                            Percipitation = 0,
                            Humidity = 53,
                            Wind = 1,
                            IconPath = "../Media/mostly sunny.png"
                        },
                        new WeatherData
                        {
                            Hour = 1,
                            Temperature = 75,
                            Condition = "Clear",

                            Percipitation = 0,
                            Humidity = 53,
                            Wind = 1,
                            IconPath = "../Media/mostly sunny.png"
                        },
                        new WeatherData
                        {
                            Hour = 1,
                            Temperature = 75,
                            Condition = "Clear",

                            Percipitation = 0,
                            Humidity = 53,
                            Wind = 1,
                            IconPath = "../Media/mostly sunny.png"
                        },
                        new WeatherData
                        {
                            Hour = 1,
                            Temperature = 75,
                            Condition = "Clear",

                            Percipitation = 0,
                            Humidity = 53,
                            Wind = 1,
                            IconPath = "../Media/mostly sunny.png"
                        },
                        new WeatherData
                        {
                            Hour = 1,
                            Temperature = 75,
                            Condition = "Clear",

                            Percipitation = 0,
                            Humidity = 53,
                            Wind = 1,
                            IconPath = "../Media/mostly sunny.png"
                        },
                    }
                },
                new Day
                {
                    DayName = "Monday",
                    AvgCondition = Location.CurrentWeather,
                    Hours = new List<WeatherData>
                    {
                        new WeatherData
                        {
                            Hour = 1,
                            Temperature = 75,
                            Condition = "Clear",

                            Percipitation = 0,
                            Humidity = 53,
                            Wind = 1,
                            IconPath = "../Media/mostly sunny.png"
                        },
                        new WeatherData
                        {
                            Hour = 1,
                            Temperature = 75,
                            Condition = "Clear",

                            Percipitation = 0,
                            Humidity = 53,
                            Wind = 1,
                            IconPath = "../Media/mostly sunny.png"
                        },
                        new WeatherData
                        {
                            Hour = 1,
                            Temperature = 75,
                            Condition = "Clear",

                            Percipitation = 0,
                            Humidity = 53,
                            Wind = 1,
                            IconPath = "../Media/mostly sunny.png"
                        },
                        new WeatherData
                        {
                            Hour = 1,
                            Temperature = 75,
                            Condition = "Clear",

                            Percipitation = 0,
                            Humidity = 53,
                            Wind = 1,
                            IconPath = "../Media/mostly sunny.png"
                        },
                        new WeatherData
                        {
                            Hour = 1,
                            Temperature = 75,
                            Condition = "Clear",

                            Percipitation = 0,
                            Humidity = 53,
                            Wind = 1,
                            IconPath = "../Media/mostly sunny.png"
                        },
                        new WeatherData
                        {
                            Hour = 1,
                            Temperature = 75,
                            Condition = "Clear",

                            Percipitation = 0,
                            Humidity = 53,
                            Wind = 1,
                            IconPath = "../Media/mostly sunny.png"
                        },
                        new WeatherData
                        {
                            Hour = 1,
                            Temperature = 75,
                            Condition = "Clear",

                            Percipitation = 0,
                            Humidity = 53,
                            Wind = 1,
                            IconPath = "../Media/mostly sunny.png"
                        },
                    }
                },
            };

            


            InitializeComponent();
            this.DataContext = this;
        }
    }
}
