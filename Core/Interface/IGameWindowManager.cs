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
    }
}
