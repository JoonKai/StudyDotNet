using OxyPlot.Axes;
using OxyPlot.Legends;
using OxyPlot.Series;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFOxyPlotGraph.Commons
{
    public class OxyPlotManger
    {
        private readonly PlotModel _plotModel = new PlotModel();
        private IList<OxyColor> _oxyColors;
        private int _oxyColorIndex;

        public OxyPlotManger(string title)
        {
            _plotModel = new PlotModel { Title = title };
        }
        public PlotModel PlotModel => _plotModel;

        /// <summary>
        /// X축 설정
        /// </summary>
        /// <param name="title"></param>
        /// <param name="stringFormat"></param>
        public void SetDateTimeAxisX(string title, string stringFormat)
        {
            //x축 생성
            PlotModel.Axes.Add(new DateTimeAxis
            {
                Position = AxisPosition.Bottom,
                Title = "일자",
                StringFormat = "yyyy-MM-dd",
                IntervalType = DateTimeIntervalType.Months,
                MajorGridlineStyle = LineStyle.Dot,
            });
        }
        /// <summary>
        /// Y축 설정
        /// </summary>
        /// <param name="title"></param>
        /// <param name=""></param>
        public void SetAxisY(string title)
        {
            //y축 생성
            PlotModel.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Left,
                Title = "점수",
            });
        }
        /// <summary>
        /// Legend 설정
        /// </summary>
        public void SetLegend()
        {
            var legend = new Legend
            {
                LegendPlacement = LegendPlacement.Outside,
                LegendPosition = LegendPosition.RightTop,
                LegendOrientation = LegendOrientation.Vertical,
            };
            PlotModel.Legends.Add(legend);
        }
        public void SetOxyColors(int count)
        {
            _oxyColors = OxyPalettes.HueDistinct(count).Colors;
        }
        public void SetNextColor()
        {
            _oxyColorIndex = _oxyColors?.Count == _oxyColorIndex ? 0 : ++_oxyColorIndex;
        }
        public void AddLineSeriesDataPoints(string title, IEnumerable<DataPoint> dataPoints)
        {
            var color = _oxyColors == null ? OxyColors.Blue : _oxyColors[_oxyColorIndex];
            var lineSeries = new LineSeries
            {
                Title = title,
                Color = color,
                MarkerStroke = color,
                StrokeThickness = 1,
                MarkerType = MarkerType.Circle,
                MarkerSize = 3,
            };

            lineSeries.Points.AddRange(dataPoints);

            PlotModel.Series.Add(lineSeries);
        }
    }
}
