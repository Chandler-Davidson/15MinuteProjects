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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Response Response { get; set; }
        public string CityName { get; set; }
        public Hour CurrentHour { get; set; }
        public string CurrentTime { get; set; }
        public string CurrentCondition { get; set; }
        public object Days { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Response = APIWrapper.GetData("Huntsville, AL");

            SetFormControls();

            SetDayView();

            WeatherIcon.Source = new BitmapImage(new Uri("../../Media/" + CurrentHour.Weather[0].Main + ".png", UriKind.Relative));


            DataContext = this;
        }


        private void SetFormControls()
        {
            CityName = Response.City.Name;

            CurrentHour = Response.List[0];
            CurrentCondition = CurrentHour.Weather[0].Main;

            this.HourlyChart.SetDays(Response.List.ToList());
        }
        

        private void DayView_MouseDown(object sender, MouseButtonEventArgs e)
        {
            foreach (DayViewControl dayControl in this.DayViewController.Children)
                dayControl.BorderBrush = Brushes.Transparent;

            var d = e.OriginalSource;            
        }

        private void SetDayView()
        {
            var d = Response.List.GroupBy(
                x => x.DtTxt.Day,
                (key, w) => new { Dt = key, Hours = w.ToList() }).ToList();

            DayViewController.Children.Clear();
            d.ForEach(x => DayViewController.Children.Add(new DayViewControl(x.Hours)));
        }

        private void ChangeViewButton_Click(object sender, RoutedEventArgs e)
        {
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (LocationTextBox.Text.Length == 0)
                {
                    LocationTextBox.BorderBrush = Brushes.Red;
                }
                else
                {
                    try
                    {
                        LocationTextBox.BorderBrush = Brushes.Transparent;

                        Response = APIWrapper.GetData(LocationTextBox.Text + ", US");

                        SetFormControls();
                        SetDayView();
                    }
                    catch (System.Net.WebException)
                    {
                        LocationTextBox.BorderBrush = Brushes.Red;
                    }
                }
            }
        }
    }
}
