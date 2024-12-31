using Core;
using Core.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace ToolMn
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Tạo Service Collection
            var services = new ServiceCollection();

            // Đăng ký các dịch vụ
            services.AddSingleton<IMouseHandler, MouseHandler>();
            services.AddSingleton<ICoordinateManager, CoordinateManager>();
            services.AddSingleton<IGameLauncher, GameLauncher>();
            services.AddSingleton<IGameWindowManager, GameWindowManager>();
            services.AddSingleton<IWindowArranger, WindowArranger>();

            // Đăng ký form
            services.AddTransient<MainForm>();

            // Build ServiceProvider
            var serviceProvider = services.BuildServiceProvider();

            // Lấy form chính từ DI container
            var mainForm = serviceProvider.GetRequiredService<MainForm>();

            Application.Run(mainForm);
        }
    }
}