namespace GrammyDevStudio.WinForms_GameCore.Debug.FPS
{
    partial class FpsWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NowBox = new GroupBox();
            RenderingLable2 = new Label();
            RenderingLable1 = new Label();
            LogicLabel2 = new Label();
            LogicLabel1 = new Label();
            FpsLabel2 = new Label();
            FpsLabel1 = new Label();
            MinFpsLable2 = new Label();
            MaxFpsLable2 = new Label();
            MinFpsLable1 = new Label();
            MaxFpsLable1 = new Label();
            AllTimeBox = new GroupBox();
            Hystory = new GroupBox();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            label4 = new Label();
            label7 = new Label();
            label2 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            NowBox.SuspendLayout();
            AllTimeBox.SuspendLayout();
            Hystory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // NowBox
            // 
            NowBox.Controls.Add(RenderingLable2);
            NowBox.Controls.Add(RenderingLable1);
            NowBox.Controls.Add(LogicLabel2);
            NowBox.Controls.Add(LogicLabel1);
            NowBox.Controls.Add(FpsLabel2);
            NowBox.Controls.Add(FpsLabel1);
            NowBox.ForeColor = SystemColors.ButtonFace;
            NowBox.Location = new Point(10, 9);
            NowBox.Margin = new Padding(3, 2, 3, 2);
            NowBox.Name = "NowBox";
            NowBox.Padding = new Padding(3, 2, 3, 2);
            NowBox.Size = new Size(217, 84);
            NowBox.TabIndex = 6;
            NowBox.TabStop = false;
            NowBox.Text = "Now";
            // 
            // RenderingLable2
            // 
            RenderingLable2.AutoSize = true;
            RenderingLable2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            RenderingLable2.Location = new Point(112, 57);
            RenderingLable2.Name = "RenderingLable2";
            RenderingLable2.Size = new Size(33, 19);
            RenderingLable2.TabIndex = 11;
            RenderingLable2.Text = "000";
            // 
            // RenderingLable1
            // 
            RenderingLable1.AutoSize = true;
            RenderingLable1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            RenderingLable1.Location = new Point(5, 57);
            RenderingLable1.Name = "RenderingLable1";
            RenderingLable1.Size = new Size(101, 19);
            RenderingLable1.TabIndex = 10;
            RenderingLable1.Text = "Rendering (ms)";
            // 
            // LogicLabel2
            // 
            LogicLabel2.AutoSize = true;
            LogicLabel2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LogicLabel2.Location = new Point(112, 38);
            LogicLabel2.Name = "LogicLabel2";
            LogicLabel2.Size = new Size(33, 19);
            LogicLabel2.TabIndex = 11;
            LogicLabel2.Text = "000";
            // 
            // LogicLabel1
            // 
            LogicLabel1.AutoSize = true;
            LogicLabel1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LogicLabel1.Location = new Point(5, 38);
            LogicLabel1.Name = "LogicLabel1";
            LogicLabel1.Size = new Size(71, 19);
            LogicLabel1.TabIndex = 10;
            LogicLabel1.Text = "Logic (ms)";
            // 
            // FpsLabel2
            // 
            FpsLabel2.AutoSize = true;
            FpsLabel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FpsLabel2.Location = new Point(53, 17);
            FpsLabel2.Name = "FpsLabel2";
            FpsLabel2.Size = new Size(37, 21);
            FpsLabel2.TabIndex = 7;
            FpsLabel2.Text = "000";
            // 
            // FpsLabel1
            // 
            FpsLabel1.AutoSize = true;
            FpsLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FpsLabel1.Location = new Point(5, 17);
            FpsLabel1.Name = "FpsLabel1";
            FpsLabel1.Size = new Size(36, 21);
            FpsLabel1.TabIndex = 3;
            FpsLabel1.Text = "FPS";
            // 
            // MinFpsLable2
            // 
            MinFpsLable2.AutoSize = true;
            MinFpsLable2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            MinFpsLable2.Location = new Point(47, 34);
            MinFpsLable2.Name = "MinFpsLable2";
            MinFpsLable2.Size = new Size(33, 19);
            MinFpsLable2.TabIndex = 6;
            MinFpsLable2.Text = "000";
            // 
            // MaxFpsLable2
            // 
            MaxFpsLable2.AutoSize = true;
            MaxFpsLable2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            MaxFpsLable2.Location = new Point(47, 17);
            MaxFpsLable2.Name = "MaxFpsLable2";
            MaxFpsLable2.Size = new Size(33, 19);
            MaxFpsLable2.TabIndex = 5;
            MaxFpsLable2.Text = "000";
            // 
            // MinFpsLable1
            // 
            MinFpsLable1.AutoSize = true;
            MinFpsLable1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            MinFpsLable1.Location = new Point(5, 34);
            MinFpsLable1.Name = "MinFpsLable1";
            MinFpsLable1.Size = new Size(33, 19);
            MinFpsLable1.TabIndex = 4;
            MinFpsLable1.Text = "Min";
            // 
            // MaxFpsLable1
            // 
            MaxFpsLable1.AutoSize = true;
            MaxFpsLable1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            MaxFpsLable1.Location = new Point(5, 17);
            MaxFpsLable1.Name = "MaxFpsLable1";
            MaxFpsLable1.Size = new Size(35, 19);
            MaxFpsLable1.TabIndex = 2;
            MaxFpsLable1.Text = "Max";
            // 
            // AllTimeBox
            // 
            AllTimeBox.Controls.Add(MaxFpsLable1);
            AllTimeBox.Controls.Add(MinFpsLable1);
            AllTimeBox.Controls.Add(MaxFpsLable2);
            AllTimeBox.Controls.Add(MinFpsLable2);
            AllTimeBox.ForeColor = SystemColors.ButtonFace;
            AllTimeBox.Location = new Point(233, 9);
            AllTimeBox.Margin = new Padding(3, 2, 3, 2);
            AllTimeBox.Name = "AllTimeBox";
            AllTimeBox.Padding = new Padding(3, 2, 3, 2);
            AllTimeBox.Size = new Size(90, 84);
            AllTimeBox.TabIndex = 12;
            AllTimeBox.TabStop = false;
            AllTimeBox.Text = "All time";
            // 
            // Hystory
            // 
            Hystory.Controls.Add(pictureBox1);
            Hystory.Controls.Add(label8);
            Hystory.Controls.Add(label4);
            Hystory.Controls.Add(label7);
            Hystory.Controls.Add(label2);
            Hystory.Controls.Add(label6);
            Hystory.Controls.Add(label5);
            Hystory.Controls.Add(label3);
            Hystory.Controls.Add(label1);
            Hystory.ForeColor = SystemColors.ButtonFace;
            Hystory.Location = new Point(10, 98);
            Hystory.Margin = new Padding(3, 2, 3, 2);
            Hystory.Name = "Hystory";
            Hystory.Padding = new Padding(3, 2, 3, 2);
            Hystory.Size = new Size(817, 340);
            Hystory.TabIndex = 12;
            Hystory.TabStop = false;
            Hystory.Text = "Hystory 60s";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Location = new Point(107, 11);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(700, 324);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(7, 52);
            label8.Name = "label8";
            label8.Size = new Size(35, 19);
            label8.TabIndex = 2;
            label8.Text = "Max";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(7, 17);
            label4.Name = "label4";
            label4.Size = new Size(35, 19);
            label4.TabIndex = 2;
            label4.Text = "Max";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(49, 52);
            label7.Name = "label7";
            label7.Size = new Size(33, 19);
            label7.TabIndex = 5;
            label7.Text = "000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(49, 17);
            label2.Name = "label2";
            label2.Size = new Size(33, 19);
            label2.TabIndex = 5;
            label2.Text = "000";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(7, 69);
            label6.Name = "label6";
            label6.Size = new Size(33, 19);
            label6.TabIndex = 4;
            label6.Text = "Min";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(49, 69);
            label5.Name = "label5";
            label5.Size = new Size(33, 19);
            label5.TabIndex = 6;
            label5.Text = "000";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(7, 34);
            label3.Name = "label3";
            label3.Size = new Size(33, 19);
            label3.TabIndex = 4;
            label3.Text = "Min";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(49, 34);
            label1.Name = "label1";
            label1.Size = new Size(33, 19);
            label1.TabIndex = 6;
            label1.Text = "000";
            // 
            // FpsWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(838, 446);
            Controls.Add(Hystory);
            Controls.Add(AllTimeBox);
            Controls.Add(NowBox);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FpsWindow";
            Text = "FpsWindow";
            NowBox.ResumeLayout(false);
            NowBox.PerformLayout();
            AllTimeBox.ResumeLayout(false);
            AllTimeBox.PerformLayout();
            Hystory.ResumeLayout(false);
            Hystory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox NowBox;
        private Label LogicLabel2;
        private Label LogicLabel1;
        private Label FpsLabel2;
        private Label MinFpsLable2;
        private Label MaxFpsLable2;
        private Label FpsLabel1;
        private Label MinFpsLable1;
        private Label MaxFpsLable1;
        private GroupBox AllTimeBox;
        private GroupBox Hystory;
        private Label label8;
        private Label label4;
        private Label label7;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label1;
        private PictureBox pictureBox1;
        private Label RenderingLable2;
        private Label RenderingLable1;
    }
}