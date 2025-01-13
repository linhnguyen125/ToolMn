using Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Vanara.PInvoke;

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

        /// <summary>
        /// Thay đổi kích thước cửa sổ
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public void ResizeWindow(nint hWnd, int width, int height)
        {
            if (hWnd == IntPtr.Zero)
            {
                //MessageBox.Show("Failed to get window handle.");
                return;
            }

            // Lấy tọa độ hiện tại của cửa sổ
            if (User32.GetWindowRect(hWnd, out var rect))
            {
                User32.SetWindowPos(hWnd, HWND.NULL, rect.left, rect.top, width, height, User32.SetWindowPosFlags.SWP_SHOWWINDOW);
            }
        }

        /// <summary>
        /// Thay đổi vị trí cửa sổ
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void SetWindowPosition(nint hWnd, int x, int y)
        {
            if (hWnd == IntPtr.Zero)
            {
                //MessageBox.Show("Failed to get window handle.");
                return;
            }

            // Lấy kích thước hiện tại của cửa sổ
            if (User32.GetWindowRect(hWnd, out var rect))
            {
                int width = rect.right - rect.left;
                int height = rect.bottom - rect.top;

                User32.SetWindowPos(hWnd, HWND.NULL, x, y, width, height, User32.SetWindowPosFlags.SWP_SHOWWINDOW);
            }
        }

        /// <summary>
        /// Tìm cửa sổ theo title
        /// </summary>
        /// <param name="windowTitle"></param>
        /// <returns></returns>
        public IntPtr FindWindowHandle(string windowTitle)
        {
            IntPtr foundHwnd = IntPtr.Zero;

            // EnumWindows callback để tìm cửa sổ theo tiêu đề
            User32.EnumWindows((hWnd, lParam) =>
            {
                // Tạo buffer để lưu tiêu đề cửa sổ
                StringBuilder titleBuilder = new StringBuilder(256); // Độ dài tối đa tiêu đề là 255 ký tự

                // Lấy tiêu đề của cửa sổ hiện tại
                int length = User32.GetWindowText(hWnd, titleBuilder, titleBuilder.Capacity);
                if (length > 0) // Kiểm tra xem cửa sổ có tiêu đề không
                {
                    string title = titleBuilder.ToString();
                    if (title == windowTitle)
                    {
                        foundHwnd = hWnd.DangerousGetHandle();
                        return false; // Dừng tìm kiếm khi tìm thấy
                    }
                }

                return true; // Tiếp tục tìm kiếm
            }, IntPtr.Zero);

            return foundHwnd;
        }

        /// <summary>
        /// Tìm cửa sổ theo processId
        /// </summary>
        /// <param name="processId"></param>
        /// <returns></returns>
        public IntPtr FindWindowHandle(uint processId)
        {
            IntPtr foundHwnd = IntPtr.Zero;
            User32.EnumWindows((hWnd, lParam) =>
            {
                User32.GetWindowThreadProcessId(hWnd, out uint lpdwProcessId);
                if (lpdwProcessId == processId)
                {
                    foundHwnd = hWnd.DangerousGetHandle();
                    return false; // Dừng tìm kiếm khi tìm thấy
                }
                return true; // Tiếp tục tìm kiếm
            }, IntPtr.Zero);

            return foundHwnd;
        }
    }
}
