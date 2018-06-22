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
        public string CityName => Response.City.Name;

        public MainWindow()
        {
            InitializeComponent();

            DataContext = this;

            var Response = APIWrapper.GetData("Huntsville, AL");

        }

        private void SetFormControls()
        {
        }

        private void DayView_MouseDown(object sender, MouseButtonEventArgs e)
        {
            foreach (DayViewControl dayControl in this.DayViewController.Children)
                dayControl.BorderBrush = Brushes.Transparent;

            var d = e.OriginalSource;
            //d.BorderBrush = Brushes.White;

            //this.HourlyChart.SelectedDay = d.Model;
            
        }

        private void ChangeViewButton_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
