using Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class CoordinateManager : ICoordinateManager
    {
        /// <summary>
        /// Chuyển đổi tọa độ từ game sang màn hình
        /// </summary>
        /// <param name="gamePoint"></param>
        /// <param name="gameWindowRect"></param>
        /// <returns></returns>
        public Point ConvertToScreen(Point gamePoint, Rectangle gameWindowRect)
        {
            return new Point(gameWindowRect.Left + gamePoint.X, gameWindowRect.Top + gamePoint.Y);
        }

        /// <summary>
        /// Kiểm tra tọa độ hợp lệ trên màn hình
        /// </summary>
        /// <param name="screenPoint"></param>
        /// <param name="screenWidth"></param>
        /// <param name="screenHeight"></param>
        /// <returns></returns>
        public bool IsValidScreenPoint(Point screenPoint, int screenWidth, int screenHeight)
        {
            return screenPoint.X >= 0 && screenPoint.X < screenWidth &&
                   screenPoint.Y >= 0 && screenPoint.Y < screenHeight;
        }
    }
}
