using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Timers;

namespace TurnScreenOFF
{
    class Program
    {
        private static int WM_SYSCOMMAND = 0x0112;
        private static uint SC_MONITORPOWER = 0xF170;

  
        public static void Main(string[] args)
        {
            SendMessage(GetConsoleWindow(), WM_SYSCOMMAND, (IntPtr)SC_MONITORPOWER, (int)2);
            //Thread.Sleep(1000);
            //SendMessage(GetConsoleWindow(), WM_SYSCOMMAND, (IntPtr)SC_MONITORPOWER, (int) -1);



        }

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int wMsg, IntPtr wParam, int lParam);
    }
}
