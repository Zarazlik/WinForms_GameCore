using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrammyDevStudio.WinForms_GameCore.Prefabs.Tile2D
{
    public interface ITile2D_Object
    {
        public void DrawObject(Graphics graphics, Point position, int size);
    }
}
