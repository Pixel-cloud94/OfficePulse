using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveCharts; //Core of the library
using LiveCharts.Wpf; //The WPF controls
using LiveCharts.WinForms; //the WinForm wrappers
using LiveCharts.Definitions.Charts;
using System.Drawing;
using System.Windows.Media;

namespace OfficePulse
{
    public static class StatData 
    {
   


        public static LineSeries CreateLineSeries(string title, ChartValues<double> values)
        {
            return new LineSeries
            {
                StrokeThickness = 2,
                StrokeDashArray = new System.Windows.Media.DoubleCollection(20),
                Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(250, 2, 40)),
                Fill = System.Windows.Media.Brushes.Transparent,
                PointGeometrySize = 15,
                PointForeground =
                new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(34, 46, 49))
            };
        }

        public static void ConfigureMonthlyChartXAxis(LiveCharts.WinForms.CartesianChart chart)
        {
            chart.AxisX.Add(new Axis
            {
                Labels = new[]
                {
                "WEEK  1",
                "WEEK  2",
                "WEEK  3",
                "WEEK  4"
            },
                Separator = new Separator
                {
                    Step = 1,
                    IsEnabled = true,
                    StrokeThickness = 2,
                    StrokeDashArray = new System.Windows.Media.DoubleCollection(2),
                    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 79, 86))
                }
            });
        }

        public static void ConfigureMonthlyChartYAxis(LiveCharts.WinForms.CartesianChart chart)
        {
            chart.AxisY.Add(new Axis
            {
                Separator = new Separator
                {
                    StrokeThickness = 2,
                    StrokeDashArray = new System.Windows.Media.DoubleCollection(2),
                    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 79, 86))
                }
            });
        }

       public static void CallMonthlyChart()
        {
           
        }
    }

}

