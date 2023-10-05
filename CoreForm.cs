using GrammyDevStudio.WinForms_GameCore.Debug.FPS;

namespace GrammyDevStudio.WinForms_GameCore
{
    public abstract partial class CoreForm : Form
    {
        internal EngineLogic Logic;
        public FpsWindow FpsWindow;

        public CoreForm()
        {
            InitializeComponent();

            Logic = new EngineLogic(this);
            FpsWindow = new FpsWindow();
        }

        private void FpsLimiter_Tick(object sender, EventArgs e)
        {
            Logic.FrameUpdate();
        }

        private void FpsCounterTimer_Tick(object sender, EventArgs e)
        {
            Logic.GetFPSData();
        }

        internal void LoadGame()
        {
            Logic.LoadGame();
        }

        internal void PauseLogic()
        {
            FpsLimiter.Stop();
        }

        internal void StartGame()
        {
            FpsLimiter.Start();
            FpsCounterTimer.Start();
        }
    }
}