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
        public Func<double, string> YFormatter { get; set; }

        public HourlyChartControl()
        {
            InitializeComponent();

            SeriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Series 1",
                    Values = new ChartValues<double> { 91, 87, 83, 76, 74, 72, 74, 84 }
                },
            };

            Labels = new[] { "2PM", "5PM", "8PM", "11PM", "2AM", "5AM", "8AM", "11AM" };

            DataContext = this;
        }
    }
}
