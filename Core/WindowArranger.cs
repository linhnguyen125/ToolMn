using Core.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class WindowArranger : IWindowArranger
    {
        [DllImport("user32.dll")]
        private static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        public void ArrangeWindows(int rows, int columns)
        {
            var processes = GetAllGameProcesses();
            if (processes.Count == 0) return;

            var screenWidth = Screen.PrimaryScreen.Bounds.Width;
            var screenHeight = Screen.PrimaryScreen.Bounds.Height;

            var windowWidth = screenWidth / columns;
            var windowHeight = screenHeight / rows;

            int x = 0, y = 0;

            foreach (var process in processes)
            {
                if (process.MainWindowHandle == IntPtr.Zero) continue;

                MoveWindow(process.MainWindowHandle, x, y, windowWidth, windowHeight, true);
                x += windowWidth;

                if (x >= screenWidth)
                {
                    x = 0;
                    y += windowHeight;
                }

                // Đảm bảo cửa sổ được focus
                SetForegroundWindow(process.MainWindowHandle);
            }
        }

        /// <summary>
        /// Lấy ra tất cả cửa sổ game theo tên
        /// </summary>
        /// <returns></returns>
        private List<Process> GetAllGameProcesses()
        {
            return new List<Process>(Process.GetProcessesByName("TênGame"));
        }
    }
}
