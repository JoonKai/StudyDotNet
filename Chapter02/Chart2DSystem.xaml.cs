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
using System.Windows.Shapes;

namespace Chapter02
{
    /// <summary>
    /// Chart2DSystem.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Chart2DSystem : Window
    {
        private double xMin = 0.0;
        private double xMax = 10.0;
        private double yMin = 0.0;
        private double yMax = 10.0;
        private Line line1;
        private Polyline polyline1;

        public Chart2DSystem()
        {
            InitializeComponent();
            AddGraphics();
        }

        private void AddGraphics()
        {
            line1= new Line();
            line1.X1 = XNomalize(2.0);
            line1.Y1 = YNomalize(4.0);
            line1.X2 = XNomalize(8.0);
            line1.Y2 = YNomalize(10.0);
            line1.Stroke = Brushes.Blue;
            line1.StrokeThickness = 2;
            plotCanvas.Children.Add(line1);

            polyline1 = new Polyline();
            polyline1.Points.Add(new Point(XNomalize(8), YNomalize(8)));
            polyline1.Points.Add(new Point(XNomalize(6), YNomalize(6)));
            polyline1.Points.Add(new Point(XNomalize(6), YNomalize(4)));
            polyline1.Points.Add(new Point(XNomalize(4), YNomalize(4)));
            polyline1.Points.Add(new Point(XNomalize(4), YNomalize(6)));
            polyline1.Points.Add(new Point(XNomalize(6), YNomalize(6)));
            polyline1.Stroke = Brushes.Red;
            polyline1.StrokeThickness = 5;
            plotCanvas.Children.Add(polyline1);
        }
        private double XNomalize(double x)
        {
            double result = (x - xMin) * plotCanvas.Width / (xMax - xMin);
            return result;
        }

        private double YNomalize(double y)
        {
            double result = plotCanvas.Height - (y - yMin) * plotCanvas.Height / (yMax - yMin);
            return result;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            xMin = Convert.ToDouble(tbXMin.Text);
            xMax = Convert.ToDouble(tbXMax.Text);
            yMin = Convert.ToDouble(tbYMin.Text);
            yMax = Convert.ToDouble(tbYMax.Text);
            plotCanvas.Children.Remove(line1);
            plotCanvas.Children.Remove(polyline1);
            AddGraphics();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
