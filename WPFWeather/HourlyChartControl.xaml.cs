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

using LiveCharts;
using LiveCharts.Wpf;

namespace WPFWeather
{
    /// <summary>
    /// Interaction logic for HourlyChartConrol.xaml
    /// </summary>
    public partial class HourlyChartControl : UserControl
    {
        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public string View { get; set; }
        private Day selectedDay;
        public Day SelectedDay
        {
            get
            {
                return selectedDay;
            }

            set
            {
                if (value != selectedDay)
                {
                    selectedDay = value;

                    SeriesCollection[0].Values.Clear();
                    SeriesCollection[0].Values.AddRange(SelectedDay.Hours.Select(x => x.Temperature).Cast<object>());

                    Labels = SelectedDay.Hours.Select(x => x.HourText).ToArray();
                }
            }
        }

        public HourlyChartControl()
        {
            InitializeComponent();

            SeriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Tempearture",
                    Values = new ChartValues<int> { 91, 87, 83, 76, 74, 72, 74, 84 }
                },
                //new LineSeries
                //{
                //    Title = "Humidity",
                //    Values = new ChartValues<double> { 91, 87, 83, 76, 74, 72, 74, 84 }
                //},
                //new LineSeries
                //{
                //    Title = "Percipitation",
                //    Values = new ChartValues<double> { 91, 87, 83, 76, 74, 72, 74, 84 }
                //},

            };

            DataContext = this;
        }
    }
}
