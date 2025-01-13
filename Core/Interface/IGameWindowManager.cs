using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interface
{
    /// <summary>
    /// Quản lý cửa sổ game
    /// </summary>
    public interface IGameWindowManager
    {
        /// <summary>
        /// Tìm cửa sổ game theo tên
        /// </summary>
        /// <param name="windowName"></param>
        /// <returns></returns>
        IntPtr GetGameWindowHandle(string windowName);

        /// <summary>
        /// Đưa cửa sổ game lên foreground
        /// </summary>
        /// <param name="hWnd"></param>
        void FocusGameWindow(IntPtr hWnd);

        /// <summary>
        /// Lấy tọa độ cửa sổ game
        /// </summary>
        /// <param name="hWnd"></param>
        /// <returns></returns>
        Rectangle? GetGameWindowRect(IntPtr hWnd);

        /// <summary>
        /// Thay đổi kích thước cửa sổ
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        void ResizeWindow(IntPtr hWnd, int width, int height);

        /// <summary>
        /// Thay đổi vị trí cửa sổ
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        void SetWindowPosition(IntPtr hWnd, int x, int y);

        /// <summary>
        /// Tìm cửa sổ theo title
        /// </summary>
        /// <param name="windowTitle"></param>
        /// <returns></returns>
        IntPtr FindWindowHandle(string windowTitle);

        /// <summary>
        /// Tìm cửa sổ theo processId
        /// </summary>
        /// <param name="processId"></param>
        /// <returns></returns>
        IntPtr FindWindowHandle(uint processId);
    }
}
