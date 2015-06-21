using System;
using System.Collections.Generic;

namespace WebChess
{
    class Knight : Piece
    {
        /// <summary>
        /// Knight Constructor
        /// </summary>
        /// <param name="color"></param>
        public Knight(PieceColor color)
            : base(color)
        {

        }

        public override List<Move> GetPossibleMoves(Position pos)
        {
            List<Move> moves = new List<Move>();
            int x = pos.x;
            int y = pos.y;

            moves.AddRange(
                new List<Move>
                {
                    new Move(pos, new Position(x - 2, y + 1)),
                    new Move(pos, new Position(x - 2, y - 1)),
                    new Move(pos, new Position(x + 2, y + 1)),
                    new Move(pos, new Position(x - 2, y - 1)),
                    new Move(pos, new Position(x + 1, y + 2)),
                    new Move(pos, new Position(x - 1, y + 2)),
                    new Move(pos, new Position(x + 1, y - 2)),
                    new Move(pos, new Position(x - 1, y - 2)),
                }
            );

            //Remove off-board moves
            moves.RemoveAll(q => q.destination.x > 7
                            || q.destination.x < 0
                            || q.destination.y > 7
                            || q.destination.y < 0);

            return moves;
        }
    }
}
