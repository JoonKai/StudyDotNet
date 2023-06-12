using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using WPFBasePro;

namespace WpfDependencyProperty
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private decimal value1;
        public decimal Value1
        {
            get => value1;
            set => SetProperty(ref value1, value);
        }
        [ObservableProperty]
        private decimal value2;
        public decimal Value2
        {
            get => value2;
            set => SetProperty(ref value2, value);
        }
        [ObservableProperty]
        private string _operator;
        public string Operator
        {
            get => _operator;
            set => SetProperty(ref _operator, value);
        }
        public MainViewModel()
        {
            Value1 = 1000;
            Value2 = 2000;
            Operator = "-";

            var timer = new DispatcherTimer()
            {
                Interval = TimeSpan.FromSeconds(1),
            };
            timer.Tick += (s, e) =>
            {
                Value1 += 1;
                Value2 += 2;
            };
            timer.Start();
        }
    }
}
