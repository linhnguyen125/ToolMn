using Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class MouseHandler : IMouseHandler
    {
        private const uint MOUSEEVENTF_MOVE = 0x0001;
        private const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const uint MOUSEEVENTF_LEFTUP = 0x0004;

        [DllImport("user32.dll")]
        private static extern bool SetCursorPos(int X, int Y);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData, int dwExtraInfo);

        /// <summary>
        /// Di chuyển chuột tới vị trí xác định
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void MoveCursor(int x, int y)
        {
            SetCursorPos(x, y);
        }

        /// <summary>
        /// Nhấn chuột trái
        /// </summary>
        public void MouseDown()
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
        }

        /// <summary>
        /// Nhả chuột trái
        /// </summary>
        public void MouseUp()
        {
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }

        /// <summary>
        /// Nhấn giữ và di chuyển chuột trái
        /// </summary>
        /// <param name="startX"></param>
        /// <param name="startY"></param>
        /// <param name="endX"></param>
        /// <param name="endY"></param>
        /// <param name="steps"></param>
        /// <param name="delay"></param>
        public void DragMouse(int startX, int startY, int endX, int endY, int steps = 10, int delay = 10)
        {
            MoveCursor(startX, startY);
            MouseDown();

            int deltaX = (endX - startX) / steps;
            int deltaY = (endY - startY) / steps;

            for (int i = 0; i <= steps; i++)
            {
                int currentX = startX + (deltaX * i);
                int currentY = startY + (deltaY * i);
                MoveCursor(currentX, currentY);
                Thread.Sleep(delay);
            }

            MouseUp();
        }
    }
}
