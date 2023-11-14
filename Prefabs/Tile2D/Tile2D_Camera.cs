namespace GrammyDevStudio.WinForms_GameCore.Prefabs.Tile2D
{
    public abstract class Tile2D_Camera : ICamera
    {
        Tile2D_World World;

        Graphics graphics;
        Bitmap bitmap;

        public Point SizePerCell;
        public Point Position;

        public short CellSize;
        byte GridWidth = 1;

        delegate void Draw(Point CellPositionOnCamera, Point CellPositionOnWorld);
        Draw DrawFlock;
        public enum FlockViewing
        {
            Family,
            Size
        }

        public PictureBox PictureBox { get; set; }

        public Tile2D_Camera(PictureBox PictureBox, Tile2D_World TileGameWorld, Point StartCameraPosition, Point StartCameraSizePerCells)
        {
            World = TileGameWorld;
            this.PictureBox = PictureBox;
            this.PictureBox.WaitOnLoad = false;

            Position = StartCameraPosition;
            SizePerCell = StartCameraSizePerCells;

            Resize();
        }

        #region Drawning

        void ICamera.MakeFrame()
        {
            MakeFrame(false);
        }

        void MakeFrame(bool FullRedraw)
        {

            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                if (FullRedraw)
                {
                    for (short x = 0; x < SizePerCell.X; x++)
                    {
                        for (short y = 0; y < SizePerCell.Y; y++)
                        {
                            FillCell(new Point(x, y));
                            World.tileCallRender[x, y] = false;
                        }
                    }
                }
                else
                {
                    for (short x = 0; x < SizePerCell.X; x++)
                    {
                        for (short y = 0; y < SizePerCell.Y; y++)
                        {
                            if (World.tileCallRender[x + Position.X, y + Position.Y])
                            {
                                FillCell(new Point(x, y));
                                World.tileCallRender[x, y] = false;
                            }
                        }
                    }
                }

                void FillCell(Point Cell)
                {
                    Point CellPositionOnCamera = new Point(GridWidth + Cell.X * (CellSize + GridWidth), GridWidth + Cell.Y * (CellSize + GridWidth));
                    Point CellPositionOnWorld = new Point(Position.X + Cell.X, Position.Y + Cell.Y);

                    for (int i = 0; i < World.tiles.Length; i++)
                    {
                        World.tiles[i][CellPositionOnWorld.X, CellPositionOnWorld.Y].DrawObject(graphics, CellPositionOnCamera, CellSize);
                    }

                }
            }

            PictureBox.Image = bitmap;
        }

        #endregion

        #region CameraPropertyChaneges
        public void Resize()
        {
            if (PictureBox.Size.Width > 0 && PictureBox.Size.Height > 0)
            {
                bitmap = new Bitmap(new Bitmap(PictureBox.Width, PictureBox.Height));
                graphics = Graphics.FromImage(bitmap);

                CellSize = (short)((PictureBox.Size.Width - (GridWidth * 2 + SizePerCell.X * GridWidth)) / SizePerCell.X);

                if (SizePerCell.Y * (CellSize + GridWidth) + GridWidth * 2 > PictureBox.Size.Height)
                {
                    CellSize = (short)((PictureBox.Size.Height - (GridWidth * 2 + SizePerCell.Y * GridWidth)) / SizePerCell.Y);
                }

                MakeFrame(true);
            }
        }

        public void ChangePosition(Point NewPosition)
        {
            bool change = false;

            if (NewPosition.X >= 0 && NewPosition.X + SizePerCell.X <= World.size.X)
            {
                Position.X = NewPosition.X;
                change = true;
            }

            if (NewPosition.Y >= 0 && NewPosition.Y + SizePerCell.Y <= World.size.Y)
            {
                Position.Y = NewPosition.Y;
                change = true;
            }

            if (change)
            {
                MakeFrame(true);
            }
        }

        public void ChangeSize(Point NewSize)
        {
            bool change = false;

            if (NewSize.X > 0 && NewSize.X <= World.size.X)
            {
                SizePerCell.X = NewSize.X;

                change = true;

                if (Position.X > 0 && Position.X + SizePerCell.X > World.size.X)
                {
                    Position.X -= Position.X + SizePerCell.X - World.size.X;
                }
            }

            if (NewSize.Y > 0 && NewSize.Y <= World.size.Y)
            {
                SizePerCell.Y = NewSize.Y;

                change = true;

                if (Position.Y > 0 && Position.Y + SizePerCell.Y > World.size.Y)
                {
                    Position.Y -= Position.Y + SizePerCell.Y - World.size.Y;
                }
            }

            if (change)
            {
                Resize();
            }
        }

        public void ChangeGrid(byte Width)
        {
            GridWidth = Width;
            Resize();
        }

        #endregion
    }
}
