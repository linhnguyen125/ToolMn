using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interface
{
    /// <summary>
    /// Quản lý tọa độ và chuyển đổi giữa các chế độ
    /// </summary>
    public interface ICoordinateManager
    {
        /// <summary>
        /// Chuyển đổi tọa độ từ game sang màn hình
        /// </summary>
        /// <param name="gamePoint"></param>
        /// <param name="gameWindowRect"></param>
        /// <returns></returns>
        Point ConvertToScreen(Point gamePoint, Rectangle gameWindowRect);

        /// <summary>
        /// Kiểm tra tọa độ hợp lệ trên màn hình
        /// </summary>
        /// <param name="screenPoint"></param>
        /// <param name="screenWidth"></param>
        /// <param name="screenHeight"></param>
        /// <returns></returns>
        bool IsValidScreenPoint(Point screenPoint, int screenWidth, int screenHeight);
    }
}
