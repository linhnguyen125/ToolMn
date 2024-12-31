using Core.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class GameLauncher : IGameLauncher
    {
        /// <summary>
        /// Khởi động game
        /// </summary>
        /// <param name="gamePath"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public Process LaunchGame(string gamePath)
        {
            if (string.IsNullOrWhiteSpace(gamePath))
                throw new ArgumentException("Game path is invalid.");

            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = gamePath,
                    UseShellExecute = true
                }
            };

            process.Start();
            return process;
        }
    }
}
