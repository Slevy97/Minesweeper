using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Minesweeper
{
    public class Music
    {
        public static void LoadMusic()
        {
            SoundPlayer s = new SoundPlayer("marconi.wav");
            s.Load();
            s.Play();
        }
    }
}
