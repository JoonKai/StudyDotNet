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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Logger.Instance.Log("폼2가 생성되었습니다.");

            this.FormClosed += Form2_FormClosed;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Logger.Instance.Log("폼2가 닫혔습니다..");
        }
    }
}
