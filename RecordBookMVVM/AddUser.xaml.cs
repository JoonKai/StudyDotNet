﻿using RecordBookMVVM.ViewModels;
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

namespace RecordBookMVVM
{
    /// <summary>
    /// AddUser.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class AddUser : Window
    {
        public AddUser()
        {
            InitializeComponent();
            AddUserViewModel addUserViewModel = new AddUserViewModel();
            this.DataContext = addUserViewModel;
        }
    }
}
