using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameEngine
{
    class Board
    {
        // Rules
        public bool Block = false;
        public bool Knuf = false;
        public bool MyTur = false;
        public bool Goal = false;
        public bool FinishLine = false;
        public bool Winner = false;
        public bool OnBoard = false;
        public bool ToDice = false;

        // Bräddelar
        public int[] PlayingField = Enumerable.Range(1, 56).ToArray();
        public int[] Stretch = Enumerable.Range(1, 5).ToArray();
        }
}
