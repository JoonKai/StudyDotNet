﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfDependencyProperty
{
    /// <summary>
    /// CalculateControl.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class CalculateControl : UserControl, INotifyPropertyChanged
    {

        void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public static readonly DependencyProperty Value1Property =
            DependencyProperty.Register("Value1", typeof(decimal), typeof(CalculateControl), new PropertyMetadata(0m, OnValueChanged, CoerceLimitValue));

        public static readonly DependencyProperty Value2Property =
            DependencyProperty.Register("Value2", typeof(decimal), typeof(CalculateControl), new PropertyMetadata(0m, OnValueChanged, CoerceLimitValue));
        public static readonly DependencyProperty OperatorProperty =
            DependencyProperty.Register("Operator", typeof(string), typeof(CalculateControl), new PropertyMetadata("+", OnValueChanged), new ValidateValueCallback(IsValidOperator));

        public static readonly DependencyProperty DesignModeProperty =
            DependencyProperty.Register("DesignMode", typeof(eDesignMode), typeof(CalculateControl), new PropertyMetadata(eDesignMode.White, OnDesignModeChanged));

        

        public eDesignMode DesignMode
        {
            get { return (eDesignMode)GetValue(DesignModeProperty); }
            set { SetValue(DesignModeProperty, value); }
        }

        public decimal Value1
        {
            get { return (decimal)GetValue(Value1Property); }
            set { SetValue(Value1Property, value); }
        }
        public decimal Value2
        {
            get { return (decimal)GetValue(Value2Property); }
            set { SetValue(Value2Property, value); }
        }
        public string Operator
        {
            get { return (string)GetValue(OperatorProperty); }
            set { SetValue(OperatorProperty, value); }
        }

        public Brush TextBoxForeground { get; set; } = Brushes.Black;         
        public Brush TextBoxBackground { get; set; } = Brushes.White;
        public Brush UserControlBackground { get; set; } = Brushes.White;

        private void ChangeDesignMode(eDesignMode designMode)
        {
            if(designMode == eDesignMode.White)
            {
                TextBoxForeground = Brushes.Black;
                TextBoxBackground = Brushes.White;
                UserControlBackground = Brushes.White;
            }
            else
            {
                TextBoxForeground = Brushes.White;
                TextBoxBackground = Brushes.DarkGray;
                UserControlBackground = Brushes.Black;
            }
            OnPropertyChanged(nameof(TextBoxForeground));
            OnPropertyChanged(nameof(TextBoxBackground));
            OnPropertyChanged(nameof(UserControlBackground));
        }
        private static void OnDesignModeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            
            //정적메서드이기 때문에 CalculateControl을 형변환 해서 가져와서 체인지 모드 가동
            CalculateControl calculateControl = (CalculateControl)d;
            if (e.NewValue != e.OldValue)
            {
                if (e.NewValue is eDesignMode designMode)
                {
                    calculateControl.ChangeDesignMode(designMode);
                }
            }
        }
        private static void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)// DependencyObject는 CalculateControl 객체가 넘어옴
        {
            CalculateControl calculateControl = (CalculateControl)d;
            calculateControl.OnPropertyChanged(nameof(Result));
        }
        private static object CoerceLimitValue(DependencyObject d, object baseValue)
        {
            decimal value = (decimal)baseValue;
            if (value < -9999)
            {
                return -9999m;
            }
            else if (value > 9999)
            {
                return 9999m;
            }
            else
            {
                return value;
            }
        }
        private static bool IsValidOperator(object value)
        {
            string oper = (string)value;
            switch (oper)
            {
                case "+":
                    return true;
                case "-":
                    return true;
                case "*":
                    return true;
                case "/":
                    return true;
            }

            return false;
        }
        public event PropertyChangedEventHandler PropertyChanged;


        private decimal result;

        public decimal Result
        {
            get
            {
                switch (Operator)
                {
                    case "+":
                        result = Value1 + Value2;
                        return result;
                    case "-":
                        result = Value1 - Value2;
                        return result;
                    case "*":
                        result = Value1 * Value2;
                        return result;
                    case "/":
                        if (Value2 == 0) 
                            result = 0; 
                        else 
                            result = Math.Round(Value1 / Value2,2);
                        return result;
                    default:
                        return result = 0m;
                }
            }
        }
        public CalculateControl()
        {
            InitializeComponent();
        }
    }
}
