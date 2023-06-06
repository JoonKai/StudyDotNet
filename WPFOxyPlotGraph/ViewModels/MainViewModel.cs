using OxyPlot;
using OxyPlot.Axes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using WPFBasePro;
using WPFOxyPlotGraph.Commons;
using WPFOxyPlotGraph.Models;

namespace WPFOxyPlotGraph.ViewModels
{

    public class MainViewModel : ViewModelBase
    {
        Func<TestScore, int> GetScoreFunc(string subJect)
        {
            switch (subJect)
            {
                case "국어":
                    return x => x.KorScore;
                case "수학":
                    return x => x.MathScore;
                case "영어":
                    return x => x.EngSore;
            }
            return default;
        }
        private void LoadOxyPlot(string subject)
        {
            Func<TestScore,int> scoreFunc = GetScoreFunc(subject);
            SetPlotModel(subject, scoreFunc);
        }
        private void SetPlotModel(string subJect, Func<TestScore,int> testScoreFunc)
        {
            IEnumerable<StudentWithScore> data = StudentWithScore.GetSeedDatas();

            var plotManager = new OxyPlotManger($"{subJect} 점수");



            //PlotModel 생성 : Plot Model은 차트가 될거임
            PlotModel = new PlotModel() { Title = "국어점수" };


            //x축 생성
            plotManager.SetDateTimeAxisX("일자", "yyy-MM-dd");

            //PlotModel.Axes.Add(new DateTimeAxis
            //{
            //    Position = AxisPosition.Bottom,
            //    Title = "일자",
            //    StringFormat = "yyyy-MM-dd",
            //    MajorGridlineStyle = LineStyle.Dot,
            //});

            //y축 생성
            plotManager.SetAxisY("점수");

            //PlotModel.Axes.Add(new LinearAxis
            //{
            //    Position = AxisPosition.Left,
            //    Title = "점수",
            //    Minimum =0,
            //    Maximum = 100,
            //});
            //Legend 추가
            plotManager.SetLegend();


            //var legend = new Legend
            //{
            //    LegendPlacement = LegendPlacement.Outside,
            //    LegendPosition = LegendPosition.RightTop,
            //    LegendOrientation = LegendOrientation.Vertical,
            //};

            //PlotModel.Legends.Add(legend);


            //데이터 추가
            var studentGroup = data.GroupBy(x => x.Student);


            //학생별 색상 추가
            plotManager.SetOxyColors(studentGroup.Count());


            //var oxyColors = OxyPalettes.HueDistinct(studentGroup.Count()).Colors;
            //int oxyColorIndex = 0;

            foreach (var studentData in studentGroup)
            {
                var dataPoints =studentData.Select(x => new DataPoint(DateTimeAxis.ToDouble(x.Score.Date), testScoreFunc(x.Score)));
                plotManager.AddLineSeriesDataPoints(studentData.Key.Name, dataPoints);
                plotManager.SetNextColor();

                //var color = oxyColors[oxyColorIndex];
                //var lineSeries = new LineSeries
                //{
                //    Title = studentData.Key.Name,
                //    Color = color,
                //    MarkerStroke = OxyColors.Black,
                //    StrokeThickness = 1,
                //    MarkerType = MarkerType.Circle,
                //    MarkerSize = 3,
                //};
                //oxyColorIndex++;

                //foreach (var sws in studentData)
                //{
                //    lineSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(sws.Score.Date), sws.Score.KorScore));
                //}
                //PlotModel.Series.Add(lineSeries);
            }
            this.PlotModel = plotManager.PlotModel;

            OnPropertyChanged(nameof(PlotModel));
        }
        public MainViewModel()
        {
            
        }
        public PlotModel PlotModel { get; set; } = default;
        public ICommand LoadOxyPlotCommand => new RelayCommand<string>(LoadOxyPlot);
    }
}
