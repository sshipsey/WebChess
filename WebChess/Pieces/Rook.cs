using System;
using System.Collections.Generic;

namespace WebChess
{
    class Rook : Piece
    {
        /// <summary>
        /// Rook Constructors
        /// </summary>
        /// <param name="color"></param>
        public Rook(PieceColor color)
            :base (color)
        {

        }
        public override List<Move> GetPossibleMoves(Position pos)
        {
            List<Move> moves = new List<Move>();
            int x = pos.x;
            int y = pos.y;

            for (int i = 1; i < 8; i++)
            {
                moves.AddRange(
                    new List<Move>
                    {
                        new Move(pos, new Position(x + i, y)),
                        new Move(pos, new Position(x - i, y)),
                        new Move(pos, new Position(x, y + i)),
                        new Move(pos, new Position(x, y - i))
                    }
                );
            }

            //Remove off-board moves
            moves.RemoveAll(q => q.destination.x > 7
                            || q.destination.x < 0
                            || q.destination.y > 7
                            || q.destination.y < 0);



            return moves;
        }
    }
}
