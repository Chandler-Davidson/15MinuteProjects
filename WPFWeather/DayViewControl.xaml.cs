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

using GetWeather;

namespace WPFWeather
{
    /// <summary>
    /// Interaction logic for DayViewControl.xaml
    /// </summary>
    public partial class DayViewControl : UserControl
    {
        public string DayName { get; set; }
        public string High { get; set; }
        public string Low { get; set; }
        public string IconPath { get; set; }
        public HourlyChartControl HourControl { get; set; }
        public List<Hour> Day { get; set; }
        public MainWindow MainWindow { get; set; }

        public DayViewControl(List<Hour> day, HourlyChartControl hourControl, MainWindow mw)
        {
            Day = day;

            HourControl = hourControl;

            MainWindow = mw;

            var avgCondition = day
                .GroupBy(x => x.Weather[0].Main)
                .OrderByDescending(y => y.Count()).FirstOrDefault()
                .Take(1)
                .Select(r => r.Weather[0].Main)
                .First();

            var avgIcon = day
                .GroupBy(x => x.Weather[0].Icon)
                .OrderByDescending(y => y.Count()).FirstOrDefault()
                .Take(1)
                .Select(r => r.Weather[0].Icon)
                .First()
                .Substring(0, 2);

            IconPath = "Media\\" + avgIcon + ".png";

            DayName = day[0].DtTxt.DayOfWeek.ToString().Substring(0, 3);

            High = Convert.ToInt32(day.Select(x => x.Main.TempMax).Max()).ToString() + "°";
            Low = Convert.ToInt32(day.Select(x => x.Main.TempMax).Min()).ToString() + "°";

            InitializeComponent();
            DataContext = this;
        }

        private void ParentGroupBox_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow.SetFormControls(Day[1]);

            HourControl.SetSelectedDay(Day);
        }
    }
}
