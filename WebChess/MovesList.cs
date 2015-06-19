using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebChess
{
    public class MovesList
    {
        /// <summary>
        /// Move origin
        /// </summary>
        public Tuple<int, int> origin { get; set; }

        /// <summary>
        /// List of destinations for move
        /// </summary>
        public List<Tuple<int, int>> destinations { get; set; }


        public MovesList(Tuple<int, int> o)
        {
            origin = o;
            destinations = new List<Tuple<int, int>>();
        }
    }
}
