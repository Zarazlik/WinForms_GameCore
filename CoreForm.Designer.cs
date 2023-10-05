using System.ComponentModel;

namespace GrammyDevStudio.WinForms_GameCore
{
    partial class CoreForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new Container();
            MainDisplay = new PictureBox();
            FpsLimiter = new System.Windows.Forms.Timer(components);
            FpsCounterTimer = new System.Windows.Forms.Timer(components);
            ((ISupportInitialize)MainDisplay).BeginInit();
            SuspendLayout();
            // 
            // MainDisplay
            // 
            MainDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MainDisplay.BackColor = SystemColors.Control;
            MainDisplay.BorderStyle = BorderStyle.FixedSingle;
            MainDisplay.Location = new Point(120, 11);
            MainDisplay.Margin = new Padding(3, 2, 3, 2);
            MainDisplay.Name = "MainDisplay";
            MainDisplay.Size = new Size(800, 600);
            MainDisplay.TabIndex = 1;
            MainDisplay.TabStop = false;
            // 
            // FpsLimiter
            // 
            FpsLimiter.Interval = 1;
            FpsLimiter.Tick += FpsLimiter_Tick;
            // 
            // FpsCounterTimer
            // 
            FpsCounterTimer.Interval = 1000;
            FpsCounterTimer.Tick += FpsCounterTimer_Tick;
            // 
            // CoreForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(5, 0, 15);
            ClientSize = new Size(932, 622);
            Controls.Add(MainDisplay);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CoreForm";
            Text = "Form1";
            ((ISupportInitialize)MainDisplay).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer FpsLimiter;
        private System.Windows.Forms.Timer FpsCounterTimer;
        public PictureBox MainDisplay;
    }
}