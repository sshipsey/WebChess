﻿using System;
using System.Collections.Generic;

namespace WebChess
{
    public class Pawn : Piece
    {
        public readonly string name = "Pawn";

        /// <summary>
        /// Pawn Constructor
        /// </summary>
        /// <param name="color"></param>
        public Pawn(PieceColor color)
            :base (color)
        {
            
        }
        
        public override List<Move> GetPossibleMoves(Position pos)
        {
            List<Move> moves = new List<Move>();
            //Get Piece color and determine move-set
            int x = pos.x;
            int y = pos.y;

            moves.AddRange(
                color <= 0 ?
                new List<Move>
                {
                    new Move(pos, new Position(x, y + 1)),
                    new Move(pos, new Position(x, y + 2)),
                    new Move(pos, new Position(x + 1, y + 1)),
                    new Move(pos, new Position(x - 1, y + 1))
                } : 
                new List<Move>
                {
                    new Move(pos, new Position(x, y - 1)),
                    new Move(pos, new Position(x, y - 2)),
                    new Move(pos, new Position(x + 1, y - 1)),
                    new Move(pos, new Position(x - 1, y - 1))
                });

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
                return "BlackPawn";
            }
            else
            {
                return "WhitePawn";
            }
        }
    }
}