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

namespace Chapter03
{
    /// <summary>
    /// ObjectMatrixTransforms.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ObjectMatrixTransforms : Window
    {
        public ObjectMatrixTransforms()
        {
            InitializeComponent();
        }

        private void btnApply_Click(object sender, RoutedEventArgs e)
        {
            Matrix m = new Matrix();
            m.M11 = Double.Parse(tbM11.Text);
            m.M12= Double.Parse(tbM12.Text);
            m.M21= Double.Parse(tbM21.Text);
            m.M22= Double.Parse(tbM22.Text);
            m.OffsetX = double.Parse(tbOffsetX.Text);
            m.OffsetY= double.Parse(tbOffsetY.Text);
            matrixTransform.Matrix= m;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
