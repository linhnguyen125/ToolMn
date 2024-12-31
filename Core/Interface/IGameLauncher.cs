using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interface
{
    /// <summary>
    /// Thực hiện tương tác với game
    /// </summary>
    public interface IGameLauncher
    {
        /// <summary>
        /// Khởi động game
        /// </summary>
        /// <param name="gamePath"></param>
        /// <returns></returns>
        Process LaunchGame(string gamePath);
    }
}
