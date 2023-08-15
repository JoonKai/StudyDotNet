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
        public Form1()
        {
            InitializeComponent();

            Logger.Instance.Log("홈버튼이 생성되었습니다.");
        }

        private void btnCreateForm2_Click(object sender, EventArgs e)
        {
            var frm2 = new Form1();
            frm2.Show();
        }

        private void btnShowLogs_Click(object sender, EventArgs e)
        {
            string logs = Logger.Instance.GetLog();
            MessageBox.Show(logs);
        }
    }
}
