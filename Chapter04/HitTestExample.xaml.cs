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

namespace Chapter04
{
    /// <summary>
    /// HitTestExample.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class HitTestExample : Window
    {
        private List<Rectangle> hitList = new List<Rectangle>();
        private EllipseGeometry hitArea = new EllipseGeometry();

        public HitTestExample()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            foreach (Rectangle rect in canvas1.Children)
            {
                rect.Fill = Brushes.LightBlue;
            }
        }

        private void canvas1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Initialize();
            Point pt = e.GetPosition(canvas1);

            hitArea = new EllipseGeometry(pt, 1.0, 1.0);
            hitList.Clear();

            VisualTreeHelper.HitTest(canvas1, null, new HitTestResultCallback(HitTestCallback), new GeometryHitTestParameters(hitArea));
            if(hitList.Count > 0)
            {
                foreach (Rectangle rect in hitList)
                {
                    rect.Fill = Brushes.LightCoral;
                }
                MessageBox.Show("You hit " + hitList.Count.ToString() + "rectangles");
            }
        }

        private HitTestResultBehavior HitTestCallback(HitTestResult result)
        {
            IntersectionDetail intersectionDetail = ((GeometryHitTestResult)result).IntersectionDetail;
            switch (intersectionDetail)
            {
                case IntersectionDetail.FullyInside:
                    return HitTestResultBehavior.Continue;
                case IntersectionDetail.FullyContains:
                    hitList.Add((Rectangle)result.VisualHit);
                    return HitTestResultBehavior.Continue;
                case IntersectionDetail.Intersects:
                    return HitTestResultBehavior.Continue;
                default:
                    return HitTestResultBehavior.Stop;
            }
        }
    }
}
