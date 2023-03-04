using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncBasicCancleToken
{
    public partial class Form1 : Form
    {
        //비동기 취소 : CancellationTokenSource
        //비동기 취소 여부 추적 : CancellationToken
        CancellationTokenSource tokenSource;
        public Form1()
        {
            InitializeComponent();
        }
        // isCancellationRequested로 멈추는법
        //private async Task DoWorkAsync(CancellationToken token)
        //{
        //    while (!token.IsCancellationRequested)
        //    {
        //        await Task.Delay(100);
        //        int.TryParse(lblIndex.Text, out int value);
        //        lblIndex.Text = (++value).ToString();
        //    }
        //}

        //error를 발생시키는 법
        private async Task DoWorkAsync(CancellationToken token)
        {
            while (true)
            {
                token.ThrowIfCancellationRequested();
                await Task.Delay(100);
                int.TryParse(lblIndex.Text, out int value);
                lblIndex.Text = (++value).ToString();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            tokenSource.Cancel();
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            tokenSource = new CancellationTokenSource();
            var token = tokenSource.Token;
            try
            {
                
                await DoWorkAsync(token);

            }
            catch (OperationCanceledException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
