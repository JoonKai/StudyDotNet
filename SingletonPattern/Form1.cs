using Microsoft.Extensions.DependencyInjection;
using SingletonPattern.Singletons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingletonPattern
{
    public partial class Form1 : Form
    {
        private readonly ILogger _logger;
        private readonly IServiceProvider _services;

        public Form1(ILogger logger, IServiceProvider services)
        {
            InitializeComponent();

            _logger = logger;
            _services = services;
            _logger.Log("폼1이 생성되었습니다.");
        }

        private void btnCreateForm2_Click(object sender, EventArgs e)
        {
            var frm2 = _services.GetService<Form2>();
            frm2?.Show();
        }

        private void btnShowLogs_Click(object sender, EventArgs e)
        {
            string logs = _logger.GetLogs();
            MessageBox.Show(logs);
        }
    }
}
