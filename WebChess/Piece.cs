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

        public abstract List<Move> GetPossibleMoves(Position pos);

        public List<Move> GetValidMoves(List<Move> m)
        {
            foreach (Move move in m)
            {
                //Rule 1: A piece cannot move onto a spot occupied by 
            }
        }

    }
}