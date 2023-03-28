using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPFOxyPlotGraph.Models;

namespace WPFOxyPlotGraph.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private void LoadOxyPlot(string subject)
        {

        }
        private void SetPlotModel()
        {
            IEnumerable<StudentWithScore> data = new List<StudentWithScore>();

            PlotModel = new PlotModel() { Title = "국어점수" };

            //x축 생성
            PlotModel.Axes.Add(new DateTimeAxis
            {
                Position = AxisPosition.Bottom,
                Title = "일자",
                StringFormat ="yyyy-MM-dd",
                MajorGridlineStyle = LineStyle.Solid,
            });
            //y축 생성\
            PlotModel.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Left,
                Title = "점수",
                Minimum =0,
                Maximum = 100,
            });
            //데이터 추가
            MessageBox.Show("손준석");
            var studentGroup = data.GroupBy(x => x.Student);
            foreach (var studentData in studentGroup)
            {
                var lineSeries = new LineSeries
                {
                    Title = studentData.Key.Name,
                    Color = OxyColors.Blue,
                    MarkerStroke = OxyColors.Blue,
                    StrokeThickness = 2,
                    MarkerType = MarkerType.Circle,
                    MarkerSize = 4,

                };
                foreach (var sws in studentData)
                {
                    lineSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(sws.Score.Date),sws.Score.KorScore));

                }
                PlotModel.Series.Add(lineSeries);
            }
            this.PlotModel = PlotModel;
        }
        public MainViewModel()
        {
            SetPlotModel();
        }
        public PlotModel PlotModel { get; set; }
        //public ICommand LoadOxyPlotCommand => new RelayCommand<string>(LoadOxyPlot);
    }
}
