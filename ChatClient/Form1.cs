using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private TcpClient _client;
        private async void connect_btn_Click(object sender, EventArgs e)
        {
            _client = new TcpClient();
            await _client.ConnectAsync(IPAddress.Parse("127.0.0.1"), 8080);
        }

        private async void send_btn_Click(object sender, EventArgs e)
        {
            NetworkStream stream =_client.GetStream();

            string text = "안녕하세요";
            var messagebuffer = Encoding.UTF8.GetBytes(text);
            stream.Write(messagebuffer, 0, messagebuffer.Length);
            byte[] buffer = new byte[1024];
            int read = await stream.ReadAsync(buffer, 0, buffer.Length);
            string message = Encoding.UTF8.GetString(buffer,0,read);

            MessageBox.Show(message);
        }
    }
}
