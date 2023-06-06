using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using WPFBasePro;
using WpfDIShowViews.Models;

namespace WpfDIShowViews.ViewModels
{
    public class SubViewModel : ViewModelBase, IParameterReceiver
    {
        public SubData SubData { get; set; } = default;
        public void ReceiveParameter(object parameter)
        {
            
            if(parameter is SubData subData)
            {
                SubData = subData;
            }
        }
    }
}
