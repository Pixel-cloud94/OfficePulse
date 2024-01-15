using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts; //Core of the library
using LiveCharts.Wpf; //The WPF controls
using LiveCharts.WinForms; //the WinForm wrappers
using LiveCharts.Definitions.Charts;


namespace OfficePulse
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            dataGridViewUsers.Rows.Add( //Test Data
               new object[]
               {
                       "ti.dersch",
                       "Tim",
                       "Dersch",
                       "IT",
                       "Software Developer"
               }
               );
            dataGridViewUsers.Rows.Add(
                new object[]
                {
                       "ka.dobel",
                       "Katharina",
                       "Dobel",
                       "HR",
                       "Secretary"
                }
                );
            dataGridViewUsers.Rows.Add(
                new object[]
                {
                       "pa.yildiz",
                       "Pailin",
                       "Yildiz",
                       "IT",
                       "Project Manager"
                }
            );

            

           
                MonthlyChart.Series.Add(new LineSeries //Lines with Data Points Monthly
            {
                Title = "IT",
                Values = new ChartValues<double> {38, 24, 46, 50 },
                StrokeThickness = 2,
                StrokeDashArray = new System.Windows.Media.DoubleCollection(20),
                Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(107, 185, 69)),
                Fill = System.Windows.Media.Brushes.Transparent,
                PointGeometrySize = 15,
                PointForeground =
                    new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(34, 46, 49))
            });
            MonthlyChart.Series.Add(new LineSeries
            {
                Title = "CS",
                Values = new ChartValues<double> { 45, 33, 25, 47 },
                StrokeThickness = 2,
                StrokeDashArray = new System.Windows.Media.DoubleCollection(20),
                Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(28, 142, 196)),
                Fill = System.Windows.Media.Brushes.Transparent,
                LineSmoothness = 1,
                PointGeometrySize = 15,
                PointForeground =
                    new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(34, 46, 49))
            });

            MonthlyChart.Series.Add(new LineSeries 
            {
                Title = "SM",
                Values = new ChartValues<double> { 35, 29, 36, 30 },
                StrokeThickness = 2,
                StrokeDashArray = new System.Windows.Media.DoubleCollection(20),
                Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(250, 2, 40)),
                Fill = System.Windows.Media.Brushes.Transparent,
                PointGeometrySize = 15,
                PointForeground =
                    new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(34, 46, 49))
            });

            MonthlyChart.Series.Add(new LineSeries 
            {
                Title = "AF",
                Values = new ChartValues<double> { 24, 44, 36, 33 },
                StrokeThickness = 2,
                StrokeDashArray = new System.Windows.Media.DoubleCollection(20),
                Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(250, 192, 2)),
                Fill = System.Windows.Media.Brushes.Transparent,
                PointGeometrySize = 15,
                PointForeground =
                    new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(34, 46, 49))
            });

            MonthlyChart.Series.Add(new LineSeries 
            {
                Title = "PO",
                Values = new ChartValues<double> { 38, 37, 26, 48 },
                StrokeThickness = 2,
                StrokeDashArray = new System.Windows.Media.DoubleCollection(20),
                Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(7, 245, 233)),
                Fill = System.Windows.Media.Brushes.Transparent,
                PointGeometrySize = 15,
                PointForeground =
                    new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(34, 46, 49))
            });

            YearlyChart.Series.Add(new LineSeries //Lines with Data Points Yearly
            {
                Title = "IT",
                Values = new ChartValues<double> { 38, 24, 46, 50, 35, 45, 28, 44, 50, 48, 38, 47 },
                StrokeThickness = 1,
                StrokeDashArray = new System.Windows.Media.DoubleCollection(20),
                Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(107, 185, 69)),
                Fill = System.Windows.Media.Brushes.Transparent,
                PointGeometrySize = 5,
                PointForeground =
                    new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(34, 46, 49))
            });
            YearlyChart.Series.Add(new LineSeries
            {
                Title = "CS",
                Values = new ChartValues<double> { 45, 33, 25, 47, 45, 33, 26, 37, 45, 23, 45, 41 },
                StrokeThickness = 1,
                StrokeDashArray = new System.Windows.Media.DoubleCollection(20),
                Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(28, 142, 196)),
                Fill = System.Windows.Media.Brushes.Transparent,
                LineSmoothness = 1,
                PointGeometrySize = 5,
                PointForeground =
                    new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(34, 46, 49))
            });

            YearlyChart.Series.Add(new LineSeries
            {
                Title = "SM",
                Values = new ChartValues<double> { 35, 29, 36, 30, 45, 23, 45, 49, 25, 33, 35, 27 },
                StrokeThickness = 1,
                StrokeDashArray = new System.Windows.Media.DoubleCollection(20),
                Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(250, 2, 40)),
                Fill = System.Windows.Media.Brushes.Transparent,
                PointGeometrySize = 5,
                PointForeground =
                    new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(34, 46, 49))
            });

            YearlyChart.Series.Add(new LineSeries
            {
                Title = "AF",
                Values = new ChartValues<double> { 24, 44, 36, 33, 45, 33, 45, 27, 41, 36, 44, 47 },
                StrokeThickness = 1,
                StrokeDashArray = new System.Windows.Media.DoubleCollection(20),
                Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(250, 192, 2)),
                Fill = System.Windows.Media.Brushes.Transparent,
                PointGeometrySize = 5,
                PointForeground =
                    new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(34, 46, 49))
            });

            YearlyChart.Series.Add(new LineSeries
            {
                Title = "PO",
                Values = new ChartValues<double> { 38, 37, 26, 38, 23, 23, 25, 37, 50, 33, 45, 47 },
                StrokeThickness = 1,
                StrokeDashArray = new System.Windows.Media.DoubleCollection(20),
                Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(7, 245, 233)),
                Fill = System.Windows.Media.Brushes.Transparent,
                PointGeometrySize = 5,
                PointForeground =
                    new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(34, 46, 49))
            });



            MonthlyChart.AxisX.Add(new Axis
            {
                Labels = new[]
                {
                    "WEEK 1",
                    "WEEK 2",
                    "WEEK 3",
                    "WEEK 4"

                },
                Separator = new Separator // force the separator step to 1, so it always display all labels
                {
                    Step = 1,
                    IsEnabled = true, //separator invisible.
                    
                    StrokeThickness = 2,
                    StrokeDashArray = new System.Windows.Media.DoubleCollection(2),
                    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 79, 86))
                }
            });

            MonthlyChart.AxisY.Add(new Axis
            {
               
                Separator = new Separator()
                {
                    StrokeThickness = 2,
                    StrokeDashArray = new System.Windows.Media.DoubleCollection(2),
                    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 79, 86))
                }
            });

            YearlyChart.AxisX.Add(new Axis
            {
                Labels = new[]
                {
                    "J",
                    "F",
                    "M",
                    "A",
                    "M",
                    "J",
                    "J",
                    "A",
                    "S",
                    "O",
                    "N",
                    "D"

                },
                Separator = new Separator // force the separator step to 1, so it always display all labels
                {
                    Step = 1,
                    IsEnabled = true, //separator invisible.

                    StrokeThickness = 2,
                    StrokeDashArray = new System.Windows.Media.DoubleCollection(2),
                    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 79, 86))
                }
            });

            YearlyChart.AxisY.Add(new Axis
            {

                Separator = new Separator()
                {
                    StrokeThickness = 2,
                    StrokeDashArray = new System.Windows.Media.DoubleCollection(2),
                    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 79, 86))
                }
            });



        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(70, 0, 0, 0);
            UserPanel.BackColor = Color.FromArgb(70, 0, 0, 0);
            StatisticsPanel.BackColor = Color.FromArgb(70, 0, 0, 0);
            ParticipitationSection.BackColor = Color.FromArgb(70, 0, 0, 0);
            
            

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.Show();
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void buttonUserPanel_Click(object sender, EventArgs e)
        {
            StatisticsPanel.Hide();
            UserPanel.Show();

        }

        private void buttonStatistics_Click(object sender, EventArgs e)
        {
            UserPanel.Hide();
            StatisticsPanel.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void MonthlyChart_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void ParticipitationSection_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
