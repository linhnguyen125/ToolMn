using Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class GameWindowManager : IGameWindowManager
    {
        [DllImport("user32.dll")]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        private static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        /// <summary>
        /// Tìm cửa sổ game theo tên
        /// </summary>
        /// <param name="windowName"></param>
        /// <returns></returns>
        public IntPtr GetGameWindowHandle(string windowName)
        {
            return FindWindow(String.Empty, windowName);
        }

        /// <summary>
        /// Đưa cửa sổ game lên foreground
        /// </summary>
        /// <param name="hWnd"></param>
        public void FocusGameWindow(IntPtr hWnd)
        {
            if (hWnd != IntPtr.Zero)
            {
                SetForegroundWindow(hWnd);
            }
        }

        /// <summary>
        /// Lấy tọa độ cửa sổ game
        /// </summary>
        /// <param name="hWnd"></param>
        /// <returns></returns>
        public Rectangle? GetGameWindowRect(IntPtr hWnd)
        {
            if (hWnd == IntPtr.Zero) return null;

            if (GetWindowRect(hWnd, out RECT rect))
            {
                return new Rectangle(rect.Left, rect.Top, rect.Right - rect.Left, rect.Bottom - rect.Top);
            }

            return null;
        }
    }
}
