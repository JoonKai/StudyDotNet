using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFBasePro;
using WpfDIShowViews.Services;

namespace WpfDIShowViews.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly IViewService _viewService;
        private void ShowSubView(object _)
        {
            _viewService.ShowSubView(new Models.SubData { StringData = "가나다", IntData =33});
        }
        public MainViewModel(IViewService viewService)
        {
            _viewService = viewService;          
        }
        public ICommand ShowSubViewCommand => new RelayCommand<object>(ShowSubView);

    }
}
