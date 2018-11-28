using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Direction Dire { get; set; }




        public Position()
        {
        }
        public Position(int x, int y, Direction dire)
        {
            X = x;
            Y = y;
            Dire = dire;
        }

    }
}
