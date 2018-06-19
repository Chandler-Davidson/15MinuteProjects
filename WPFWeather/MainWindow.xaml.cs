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

            


            InitializeComponent();
            this.DataContext = this;

            this.HourlyChart.SelectedDay = new Day()
            {
                DayName = "Thursday",
                AvgCondition = new WeatherData
                {
                    Temperature = 97,
                    Condition = "Rain",
                },

                Hours = new List<WeatherData>()
                {
                    new WeatherData()
                    {
                        Hour = 12,
                        Temperature = 90
                    },
                    new WeatherData()
                    {
                        Hour = 2,
                        Temperature = 85
                    },
                    new WeatherData()
                    {
                        Hour = 3,
                        Temperature = 95
                    },
                    new WeatherData()
                    {
                        Hour = 4,
                        Temperature = 90
                    },
                    new WeatherData()
                    {
                        Hour = 5,
                        Temperature = 80
                    }
                }
            };
        }

        private void DayView_MouseDown(object sender, MouseButtonEventArgs e)
        {
            foreach (DayViewControl dayControl in this.DayViewController.Children)
                dayControl.BorderBrush = Brushes.Transparent;

            var d = e.OriginalSource;
            //d.BorderBrush = Brushes.White;

            //this.HourlyChart.SelectedDay = d.Model;
            
        }
    }
}
