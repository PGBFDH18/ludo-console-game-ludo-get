using System;
using System.Collections.Generic;
using System.Text;

namespace GameEngine
{
    class Piece
    {
        public bool InPlay = false;
        public bool InStretch = false;
        public bool Finished = false;

        public int Number;
        private string color;
        private int startPosition;
        public int Position = 0;

        public int StartPosition
        {
            get { return startPosition; }
            set
            {
                if (color == "Red")
                {
                    startPosition = 1;
                }
                else if (color == "Blue")
                {
                    startPosition = 15;
                }
                else if (color == "Green")
                {
                    startPosition = 29;
                }
                else if (color == "Yellow")
                {
                    startPosition = 43;
                }
            }
        }
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
                StartPosition = 0;
            }
        }
    }
}