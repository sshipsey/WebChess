using System;
using System.Collections.Generic;

namespace WebChess
{
    public class Bishop : Piece
    {
        public readonly string name = "Bishop";

        /// <summary>
        /// Bishop Constructor
        /// </summary>
        /// <param name="color"></param>
        public Bishop(PieceColor color)
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
                
                moves.Add(new Move(pos, new Position(x + i, y + i)));
                moves.Add(new Move(pos, new Position(x - i, y + i)));
                moves.Add(new Move(pos, new Position(x + i, y - i)));
                moves.Add(new Move(pos, new Position(x - i, y - i)));
            }

            //Remove off-board moves
            moves.RemoveAll(q => q.destination.x > 7
                            || q.destination.x < 0
                            || q.destination.y > 7
                            || q.destination.y < 0);


            return moves;
        }

        public override string ToString()
        {
            if (color == PieceColor.Black)
            {
                return "BlackBishop";
            }
            else
            {
                return "WhiteBishop";
            }
        }
    }
}
