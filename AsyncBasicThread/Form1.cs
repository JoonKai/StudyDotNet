using AsyncBasicThread.Utils;
using System.Diagnostics;

namespace AsyncBasicThread
{
    public partial class Form1 : Form
    {
        private const string SOURCE_FILE = @"D:\\Source\\300NTK-758.mp4";
        private const string DESTINATION_FILE = @"D:\\Destination\\300NTK-758.mp4";
        private int CurrentThreadId => Thread.CurrentThread.ManagedThreadId;
        private void FileProgress(string currentUnits, string totalUnits, int percentage)
        {
            if (this.InvokeRequired)
            {
                BeginInvoke(new FileProgressDelegate(FileProgress), currentUnits, totalUnits, percentage);
            }
            else
            {
                lblMain.Text = $"{currentUnits} /{totalUnits} ({percentage}%)";
                progressMain.Value = percentage;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        private async Task CopyFileAsync()
        {
            Debug.Print($"CopyFIleAsync : {CurrentThreadId}");
            FileUtils.Copy(SOURCE_FILE, DESTINATION_FILE, fileProgress: FileProgress);
        }
        private async void btnCopyMain_Click(object sender, EventArgs e)
        {
            Debug.Print($"시작 : {CurrentThreadId}");
            await CopyFileAsync();
        }

        private async Task CopyFileBackAsync()
        {
            await Task.Run(() =>
            {
                Debug.Print($"CopyFIleAsync : {CurrentThreadId}");
                FileUtils.Copy(SOURCE_FILE, DESTINATION_FILE, fileProgress: FileProgress);
            });
        }
        private async void btnCopyBack_Click(object sender, EventArgs e)
        {
            Debug.Print($"시작 : {CurrentThreadId}");
            await CopyFileBackAsync();
        }
    }
}