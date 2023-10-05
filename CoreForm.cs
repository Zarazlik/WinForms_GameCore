using GrammyDevStudio.WinForms_GameCore.DebugTools.FPS;

namespace GrammyDevStudio.WinForms_GameCore
{
    public partial class CoreForm : Form
    {
        public GameLogic GameLogic;
        public FpsWindow FpsWindow;

        public CoreForm()
        {
            InitializeComponent();
            FpsWindow = new FpsWindow();
        }

        private void FpsLimiter_Tick(object sender, EventArgs e)
        {
            GameLogic.FrameUpdate();
        }

        private void FpsCounterTimer_Tick(object sender, EventArgs e)
        {
            GameLogic.GetFPSData();
        }

        public void LoadGame()
        {
            GameLogic.LoadGame();
        }

        public void PauseLogic()
        {
            FpsLimiter.Stop();
        }

        public void StartGame()
        {
            FpsLimiter.Start();
            FpsCounterTimer.Start();
        }
    }
}