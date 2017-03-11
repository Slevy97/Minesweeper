using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    class Coord
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Poz { get; set; }
        public Coord(int x,int y,int poz)
        {
            X = x;
            Y = y;
            Poz = poz;
        }
    }
}
