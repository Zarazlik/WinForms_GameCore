﻿using System.Diagnostics;

namespace GrammyDevStudio.WinForms_GameCore
{
    class EngineLogic
    {
        internal CoreForm CoreForm;

        byte FpsCount;
        long LogicTime;
        long RenderingTime;

        internal virtual ICamera Camera { get; set; }

        internal EngineLogic(CoreForm CoreForm)
        {
            this.CoreForm = CoreForm;
        }

        async public void FrameUpdate()
        {
            //Logic
            long ms = await Task.Run(Frame);
            long Frame()
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                Update();

                stopwatch.Stop();
                return stopwatch.ElapsedMilliseconds;
            }
            LogicTime += ms;

            //Rendering
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Camera.MakeFrame();

            stopwatch.Stop();
            RenderingTime = stopwatch.ElapsedMilliseconds;

            // Count Frames
            FpsCount++;
        }

        public virtual void Update() { }

        public virtual void LoadGame() { }

        public void GetFPSData()
        {
            CoreForm.FpsWindow.Update(FpsCount, LogicTime, RenderingTime);
            FpsCount = 0;
            LogicTime = 0;
        }
    }
}
