using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameEngine
{
    class Board
    {
        // Rules
        public bool Block;
        public bool Knuff;
        public bool MyTurn;
        public bool Goal;
        public bool FinishLine;
        public bool Winner;
        public bool OnBoard;
        public bool ToDice;

        // Bräddelar
        public Type Start;
        public int[] PlayingField = Enumerable.Range(1, 56).ToArray();
        public int[] Stretch = Enumerable.Range(1, 5).ToArray();
        public Type GoalState;
        }
}
