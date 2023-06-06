using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfDIShowViews.Models;
using WpfDIShowViews.ViewModels;
using WpfDIShowViews.Views;

namespace WpfDIShowViews.Services
{
    public class ViewService : IViewService
    {
        private readonly IServiceProvider _serviceProvider;
        public ViewService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;  
        }
        public void ShowView<TView, TViewModel>(object parameter = null)
            where TView : Window
            where TViewModel : INotifyPropertyChanged
        {
            var viewModel = (INotifyPropertyChanged)_serviceProvider.GetService(typeof(TViewModel));
            var view = (Window)_serviceProvider.GetService(typeof(TView));

            if(parameter !=null && viewModel is IParameterReceiver parameterReceiver) 
            {
                parameterReceiver.ReceiveParameter(parameter);
            }

            view.DataContext = viewModel;
            view.Show();
        }
        public void ShowMainView()
        {
            ShowView<MainView, MainViewModel>();
        }
        private bool ActivateView<TView>() where TView : Window
        {
            //창이 하나만 켜지도록함
            IEnumerable<Window> windows = Application.Current.Windows.OfType<TView>();// 현재 실행되어있는 Window 들을 불러옴
            if (windows.Any())
            {
                windows.ElementAt(0).Activate();
                return true;
            }
            else
            {
                return false;
            }
        }
        public void ShowSubView(SubData subData)
        {
            if (!ActivateView<SubView>())
            {
                ShowView<SubView, SubViewModel>(subData);
            }
        }
    }
}
