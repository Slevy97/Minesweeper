using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public class MButtons
    {
        public int i { get; set; }
        public int j { get; set; }
        public Button b {get; set;}
        public bool ButtonPressed {get; set;}
        public bool RightClick { get; set; }
        public MButtons(int x,int y,Button c, bool ButtonP)
        {
            i = x;
            j = y;
            b = c;
            ButtonPressed = ButtonP;
            RightClick = false;
        }
    }
}
