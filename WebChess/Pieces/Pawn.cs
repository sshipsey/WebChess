using System;
using System.Collections.Generic;

namespace WebChess
{
    class Pawn : Piece
    {
        /// <summary>
        /// Pawn Constructor
        /// </summary>
        /// <param name="color"></param>
        public Pawn(PieceColor color)
            :base (color)
        {
            
        }
        
        public override MovesList GetMoves(Board b, Tuple<int, int> pos)
        {
            MovesList moves = new MovesList(pos);

            //Get Piece color and determine move-set
            moves.destinations = (int)b.GetPiece(pos).color <= 0 ?
                new List<Tuple<int, int>>
                {
                    Tuple.Create(pos.Item1, pos.Item2 + 1),
                    Tuple.Create(pos.Item1, pos.Item2 + 2)
                } : 
                new List<Tuple<int, int>>
                {
                    Tuple.Create(pos.Item1, pos.Item2 - 1),
                    Tuple.Create(pos.Item1, pos.Item2 - 2)
                };
            
            return moves;
        }
        
    }
}
