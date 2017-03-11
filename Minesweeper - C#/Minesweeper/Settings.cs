using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public class Settings
    {
        public static bool GameOver { get; set; }
        public static bool StartTimer { get; set; }
        public static int Time { get; set; }
        public static bool Win { get; set; }
        public static int FlagsNumber { get; set; }
        public static bool DontStop { get; set; }
        public static int GamesPlayed { get; set; }
        public static int GamesWon { get; set; }
        public Settings()
        {
            GameOver = false;
            StartTimer = false;
            Time = 0;
            Win = false;
            FlagsNumber = 0;
            DontStop = true;
            GamesPlayed = 0;
            GamesWon = 0;
        }
    }
}
