using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebChess
{
    public class Position
    {
        /// <summary>
        /// X Coordinate
        /// </summary>
        public int x;

        /// <summary>
        /// Y Coordinate
        /// </summary>
        public int y;

        public Position(int a, int b)
        {
            x = a;
            y = b;
        }
    }
}
