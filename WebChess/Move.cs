using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebChess
{
    public class Move
    {
        /// <summary>
        /// Piece location origin
        /// </summary>
        public Position origin { get; set; }

        /// <summary>
        /// Piece location destination
        /// </summary>
        public Position destination { get; set; }
    }
}
