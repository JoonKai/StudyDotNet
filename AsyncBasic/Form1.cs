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

namespace AsyncBasic
{
    public partial class window : Form
    {
        public window()
        {
            InitializeComponent();
        }
        private void RunAnything(Label lbl)
        {
            for (int i = 0; i < 30; i++)
            {
                Thread.Sleep(100);
                lbl.Text = i.ToString();
                lbl.Refresh();
            }
        }
        private async void RunAnythingAsync(Label lbl)
        {
            for (int i = 0; i < 30; i++)
            {
                await Task.Delay(100); //비동기에서는 Thread sleep을 사용하지 않고 task.delay를 사용한다.
                lbl.Text = i.ToString();
                lbl.Refresh();
            }
        }
        private void btnTalking_Click(object sender, EventArgs e)
        {
            //RunAnything(lblTalking);
            RunAnythingAsync(lblTalking);
        }

        private void btnPhone_Click(object sender, EventArgs e)
        {
            //RunAnything(lblPhone);
            RunAnythingAsync(lblPhone);
        }

        private void btnWalking_Click(object sender, EventArgs e)
        {
            //RunAnything(lblWalking);
            RunAnythingAsync(lblWalking);
        }
        //Task를 반환해야 await을 사용할 수 있다.
        private async Task RunAllAsync(Label lbl) //비동기 메서드는 반환값으로 Task를 갖게된다. 만약 형식을 반환하고 싶다면 Task<string> 이런식으로 넣어줄 수 있다.
        {
            for (int i = 0; i < 30; i++)
            {
                await Task.Delay(100); //비동기에서는 Thread sleep을 사용하지 않고 task.delay를 사용한다.
                lbAll.Items.Add($"{lbl.Name}-{i}");
            }
        }
        //async가 항상 있어야 await을 사용할 수 있다.
        private async void btnAll_Click(object sender, EventArgs e)
        {
            await RunAllAsync(lblWalking); //await은 비동기 메서드가 모두 완료될때까지 대기를 하겠다.
            await RunAllAsync(lblPhone);
            await RunAllAsync(lblTalking);
        }
    }
}
