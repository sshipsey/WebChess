using System;
using System.Collections.Generic;

namespace WebChess
{
    public abstract class Piece
    {
        public PieceColor color { get; }

        public Piece(PieceColor pieceColor)
        {
            color = pieceColor;
        }

        public abstract MovesList GetMoves(Board b, Tuple<int, int> pos);
    }
}