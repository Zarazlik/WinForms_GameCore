namespace GrammyDevStudio.WinForms_GameCore.Debug.FPS
{
    public partial class FpsWindow : Form
    {
        int MaxFPS = 0, MinFPS = 1000;
        int FpsCount;
        long LogicTime;
        long RenderingTime;

        Chart chart;

        byte[] FpsesMinute;

        public FpsWindow()
        {
            InitializeComponent();

            chart = new Chart(pictureBox1, 60, 0, 70, 5);
            FpsesMinute = new byte[60];
        }

        async public void Update(byte FpsCount, long LogicTime, long RenderingTime)
        {
            this.FpsCount = FpsCount;
            this.LogicTime = LogicTime;
            this.RenderingTime = RenderingTime;

            AddToFpses(FpsCount);
            chart.Update(FpsesMinute);

            Now();
            AllTime();
        }

        void AddToFpses(byte b)
        {
            for (int i = 0; i < FpsesMinute.Length - 1; i++)
            {
                FpsesMinute[i] = FpsesMinute[i + 1];
            }

            FpsesMinute[FpsesMinute.Length - 1] = b;
        }

        void Now()
        {
            FpsLabel2.Text = FpsCount.ToString();
            LogicLabel2.Text = LogicTime.ToString();
            RenderingLable2.Text = RenderingTime.ToString();
        }

        void AllTime()
        {
            if (FpsCount > MaxFPS)
            {
                MaxFPS = FpsCount;
                MaxFpsLable2.Text = MaxFPS.ToString();
            }
            else if (FpsCount < MinFPS)
            {
                MinFPS = FpsCount;
                MinFpsLable2.Text = MinFPS.ToString();
            }
        }
    }
}
