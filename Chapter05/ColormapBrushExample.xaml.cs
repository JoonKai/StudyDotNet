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

namespace Chapter05
{
    /// <summary>
    /// ColormapBrushExample.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ColormapBrushExample : Window
    {
        public ColormapBrushExample()
        {
            InitializeComponent();
            FillRectangles();
            AddMathFunction();
        }

        private void AddMathFunction()
        {
            ColorMapBrush brush1 = new ColorMapBrush();
            brush1.StartPoint = new Point(0, 0);
            brush1.EndPoint = new Point(0, 1);
            Polyline line1 = new Polyline();
            for (int i = 0; i < 250; i++)
            {
                double x = i;
                double y = 70 + 50 * Math.Sin(x / 4.0 / Math.PI);
                line1.Points.Add(new Point(x, y));
            }
            line1.Stroke = brush1.Spring();
            line1.StrokeThickness = 5;
            Canvas.SetLeft(line1, 20);
            canvas1.Children.Add(line1);

            brush1 = new ColorMapBrush();
            brush1.StartPoint = new Point(0, 0);
            brush1.EndPoint = new Point(0, 1);
            line1 = new Polyline();
            for (int i = 0; i < 250; i++)
            {
                double x = i;
                double y = 70 + 50 * Math.Cos(x / 4.0 / Math.PI);
                line1.Points.Add(new Point(x, y));
            }
            line1.Stroke = brush1.Jet();
            line1.StrokeThickness = 5;
            Canvas.SetLeft(line1, 20);
            canvas1.Children.Add(line1);
        }

        private void FillRectangles()
        {
            ColorMapBrush brush = new ColorMapBrush();
            rect1.Fill = brush.Spring();

            brush = new ColorMapBrush();
            rect2.Fill = brush.Summer();

            brush = new ColorMapBrush();
            rect3.Fill = brush.Autumn();

            brush = new ColorMapBrush();
            rect4.Fill = brush.Winter();

            brush = new ColorMapBrush();
            rect5.Fill = brush.Jet();

            brush = new ColorMapBrush();
            rect6.Fill = brush.Gray();

            brush = new ColorMapBrush();
            rect7.Fill = brush.Hot();

            brush = new ColorMapBrush();
            rect8.Fill = brush.Cool();
        }
    }
}
