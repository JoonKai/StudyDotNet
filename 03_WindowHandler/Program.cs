using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _03_WindowHandler
{
    public class Program
    {
        [DllImport("user32.dll")]
        public static extern int FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll")]
        public static extern int SendMessage(int hwnd, int wMsg, int wParam, int lParam);
        static void Main(string[] args)
        {
            int hw = FindWindow("Button", "시작");
            const int WM_CLICK = 0x00F5;
            SendMessage(hw,WM_CLICK, 0, 1);
        }
    }
}
