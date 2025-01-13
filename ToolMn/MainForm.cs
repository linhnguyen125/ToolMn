using Core;
using Core.Interface;
using Microsoft.VisualBasic.ApplicationServices;
using System.Windows.Forms;

namespace ToolMn
{
    public partial class MainForm : Form
    {
        private readonly IMouseHandler _mouseHandler;
        private readonly IGameWindowManager _gameWindowManager;
        private readonly IGameLauncher _gameLauncher;

        public MainForm(IMouseHandler mouseHandler, IGameWindowManager gameWindowManager, IGameLauncher gameLauncher)
        {
            _mouseHandler = mouseHandler;
            _gameWindowManager = gameWindowManager;
            _gameLauncher = gameLauncher;
            InitializeComponent();
        }

        private void Test_click(object sender, EventArgs e)
        {
            //_mouseHandler.DragMouse(300, 300, 500, 500);
            string gamePath = "";
            var process = _gameLauncher.LaunchGame(gamePath);
            Thread.Sleep(2000);
            var hWnd = _gameWindowManager.FindWindowHandle("AngelChip Emulator");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
