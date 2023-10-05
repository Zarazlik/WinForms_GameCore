namespace GrammyDevStudio.WinForms_GameCore.Debug
{
    internal class Chart
    {
        PictureBox PictureBox;
        Image Table;

        short NumberOfPoles;

        int MaxValue, MinValue;
        int GreadVolumeStap;

        byte MinIndent = 3;
        int IndentX;

        ushort[] PolesPositions;

        public Chart(PictureBox pictureBox, short NumberOfPoles, int MinValue, int MaxValue, int GreadVolumeStap)
        {
            PictureBox = pictureBox;
            this.NumberOfPoles = NumberOfPoles;
            this.MaxValue = MaxValue;
            this.MinValue = MinValue;
            this.GreadVolumeStap = GreadVolumeStap;
            PolesPositions = new ushort[NumberOfPoles];

            DrawGread();
        }

        public void Update(byte[] Values)
        {
            Point[] Points = new Point[NumberOfPoles];

            double factor = (double)(PictureBox.Height - (MinIndent * 2 + 1)) / (MaxValue - MinValue);

            for (int i = 0; i < Values.Length; i++)
            {
                Points[i] = new Point(PolesPositions[i] + MinIndent, (int)(PictureBox.Height - Values[i] * factor) - (MinIndent + 1));
            }

            Image image = DrawChartLine(Color.Red, Points);
            PictureBox.Image = image;

        }

        void DrawGread()
        {
            Table = new Bitmap(PictureBox.Width, PictureBox.Height);

            Color GridColor = Color.FromArgb(130, 130, 130);

            ushort HorisontalLiens = (ushort)((MaxValue - MinValue) / GreadVolumeStap);

            float VerticalLinesStep = (float)(PictureBox.Width - (MinIndent * 2 + 1)) / (NumberOfPoles - 1);
            float HorisontallLinesStep = (float)(PictureBox.Height - (MinIndent * 2 + 1)) / HorisontalLiens;

            using (var graphics = Graphics.FromImage(Table))
            {
                Pen pen = new Pen(GridColor);

                for (int i = 0; i < NumberOfPoles; i++)
                {
                    graphics.DrawLine(
                        pen,
                        new Point((int)(i * VerticalLinesStep + MinIndent), MinIndent),
                        new Point((int)(i * VerticalLinesStep + MinIndent), PictureBox.Height - (MinIndent + 1)));

                    PolesPositions[i] = (ushort)(i * VerticalLinesStep + IndentX);
                }

                for (int i = 0; i <= HorisontalLiens; i++)
                {
                    graphics.DrawLine(
                        pen,
                        new Point(MinIndent, (int)(i * HorisontallLinesStep + MinIndent)),
                        new Point(PictureBox.Width - (MinIndent + 1), (int)(i * HorisontallLinesStep + MinIndent)));
                }
            }

            PictureBox.Image = Table;
        }


        Image DrawChartLine(Color color, Point[] points)
        {
            Image image = Table.Clone() as Image;

            Pen pen = new Pen(color);
            pen.Width = 2;

            using (var graphics = Graphics.FromImage(image))
            {
                graphics.DrawLines(pen, points);
            }

            return image;
        }

    }
}
