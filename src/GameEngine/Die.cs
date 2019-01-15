using System;
using System.Collections.Generic;
using System.Text;

namespace GameEngine
{
    public class Die
    {
        Random rnd = new Random();
        public int Roll()
        {
            int tmp = rnd.Next(1, 7);
            return tmp;
        }
    }
}