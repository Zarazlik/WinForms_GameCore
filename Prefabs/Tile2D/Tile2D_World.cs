using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrammyDevStudio.WinForms_GameCore.Prefabs.Tile2D
{
    public struct Tile2D_World
    {
        public ITile2D_Object[][,] tiles;
        public bool[,] tileCallRender;

        public readonly Point size;

        public Tile2D_World(int LayersCount, int XSize, int YSize)
        {
            size = new Point(XSize, YSize);

            tiles = new ITile2D_Object[LayersCount][,];
            for (int i = 0; i < LayersCount; i++) 
            {
                tiles[i] = new ITile2D_Object[XSize, YSize]; 
            }

            tileCallRender = new bool[XSize, YSize];
        }
    }
}
