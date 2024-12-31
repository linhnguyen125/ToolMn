using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interface
{
    /// <summary>
    /// Xử lý các hành vi liên quan đến chuột
    /// </summary>
    public interface IMouseHandler
    {
        /// <summary>
        /// Di chuyển chuột tới vị trí xác định
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        void MoveCursor(int x, int y);

        /// <summary>
        /// Nhấn chuột trái
        /// </summary>
        void MouseDown();

        /// <summary>
        /// Nhả chuột trái
        /// </summary>
        void MouseUp();

        /// <summary>
        /// Nhấn giữ và di chuyển chuột trái
        /// </summary>
        /// <param name="startX"></param>
        /// <param name="startY"></param>
        /// <param name="endX"></param>
        /// <param name="endY"></param>
        /// <param name="steps"></param>
        /// <param name="delay"></param>
        void DragMouse(int startX, int startY, int endX, int endY, int steps = 10, int delay = 10);
    }
}
