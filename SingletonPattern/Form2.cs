using SingletonPattern.Singletons;
using System.Windows.Forms;

namespace SingletonPattern
{
    public partial class Form2 : Form
    {
        private readonly ILogger _logger;

        public Form2(ILogger logger)
        {
            InitializeComponent();

            _logger = logger;
            _logger.Log("폼2가 생성되었습니다.");

            this.FormClosed += Form2_FormClosed;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            _logger.Log("폼2가 닫혔습니다..");
        }
    }
}
