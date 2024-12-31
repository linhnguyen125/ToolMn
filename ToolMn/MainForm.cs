using Core;
using Core.Interface;

namespace ToolMn
{
    public partial class MainForm : Form
    {
        private readonly IMouseHandler _mouseHandler;
        private readonly ICoordinateManager _coordinateManager;
        private readonly IGameWindowManager _gameWindowManager;
        private readonly IGameLauncher _gameLauncher;
        private readonly IWindowArranger _windowArranger;

        public MainForm(IMouseHandler mouseHandler, ICoordinateManager coordinateManager, IGameWindowManager gameWindowManager, IGameLauncher gameLauncher, IWindowArranger windowArranger)
        {
            _mouseHandler = mouseHandler;
            _coordinateManager = coordinateManager;
            _gameWindowManager = gameWindowManager;
            _gameLauncher = gameLauncher;
            _windowArranger = windowArranger;
            InitializeComponent();
        }

        private void Test_click(object sender, EventArgs e)
        {
            _mouseHandler.DragMouse(300, 300, 500, 500);
        }
    }
}
