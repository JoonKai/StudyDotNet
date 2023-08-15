using Microsoft.Extensions.DependencyInjection;
using SingletonPattern.Singletons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingletonPattern
{
    internal static class Program
    {
        //의존성 주입 코드
        private static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddSingleton<ILogger, Logger>();
            services.AddTransient<Form1>();
            services.AddTransient<Form2>();


            return services.BuildServiceProvider();
        }

        [STAThread]
        static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            var services = ConfigureServices();
            var form1 = services.GetService<Form1>();



            Application.EnableVisualStyles();
            Application.Run(form1);
        }
    }
}
