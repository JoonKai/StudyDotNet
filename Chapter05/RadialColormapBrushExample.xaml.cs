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
    /// RadialColormapBrushExample.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class RadialColormapBrushExample : Window
    {
        public RadialColormapBrushExample()
        {
            InitializeComponent();
            FillEllipses();
        }

        private void FillEllipses()
        {
            RadialColorMapBrush brush = new RadialColorMapBrush();
            ellipse1.Fill = brush.Spring();

            brush = new RadialColorMapBrush();
            ellipse2.Fill = brush.Summer();

            brush = new RadialColorMapBrush();
            ellipse3.Fill = brush.Autumn();

            brush = new RadialColorMapBrush();
            ellipse4.Fill = brush.Winter();

            brush = new RadialColorMapBrush();
            ellipse5.Fill = brush.Jet();

            brush = new RadialColorMapBrush();
            ellipse6.Fill = brush.Gray();

            brush = new RadialColorMapBrush();
            ellipse7.Fill = brush.Hot();

            brush = new RadialColorMapBrush();
            ellipse8.Fill = brush.Cool();
        }
    }
}
