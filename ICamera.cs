using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrammyDevStudio.WinForms_GameCore
{
    public interface ICamera
    {
        PictureBox PictureBox { get; set; }

        public void MakeFrame();
        public void Resize();
    }
}
