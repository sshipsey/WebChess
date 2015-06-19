using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebChess
{
    public class Board
    {
        private Dictionary<Tuple<int, int>, Piece> state;

        /// <summary>
        /// Initialize default board state
        /// </summary>
        /// <returns></returns>
        public static Board NewBoard()
        {
            var board = new Board();

            board.state = new Dictionary<Tuple<int, int>, Piece>
            {
                //White's Pieces
                { new Tuple<int, int>(0,0), new Rook(PieceColor.White) },
                { new Tuple<int, int>(1,0), new Knight(PieceColor.White) },
                { new Tuple<int, int>(2,0), new Bishop(PieceColor.White) },
                { new Tuple<int, int>(3,0), new King(PieceColor.White) },
                { new Tuple<int, int>(4,0), new Queen(PieceColor.White) },
                { new Tuple<int, int>(5,0), new Bishop(PieceColor.White) },
                { new Tuple<int, int>(6,0), new Knight(PieceColor.White) },
                { new Tuple<int, int>(7,0), new Rook(PieceColor.White) },
                { new Tuple<int, int>(0,1), new Pawn(PieceColor.White) },
                { new Tuple<int, int>(1,1), new Pawn(PieceColor.White) },
                { new Tuple<int, int>(2,1), new Pawn(PieceColor.White) },
                { new Tuple<int, int>(3,1), new Pawn(PieceColor.White) },
                { new Tuple<int, int>(4,1), new Pawn(PieceColor.White) },
                { new Tuple<int, int>(5,1), new Pawn(PieceColor.White) },
                { new Tuple<int, int>(6,1), new Pawn(PieceColor.White) },
                { new Tuple<int, int>(7,1), new Pawn(PieceColor.White) },

                //Black's Pieces
                { new Tuple<int, int>(0,7), new Rook(PieceColor.Black) },
                { new Tuple<int, int>(1,7), new Knight(PieceColor.Black) },
                { new Tuple<int, int>(2,7), new Bishop(PieceColor.Black) },
                { new Tuple<int, int>(3,7), new Queen(PieceColor.Black) },
                { new Tuple<int, int>(4,7), new King(PieceColor.Black) },
                { new Tuple<int, int>(5,7), new Bishop(PieceColor.Black) },
                { new Tuple<int, int>(6,7), new Knight(PieceColor.Black) },
                { new Tuple<int, int>(7,7), new Rook(PieceColor.Black) },
                { new Tuple<int, int>(0,6), new Pawn(PieceColor.Black) },
                { new Tuple<int, int>(1,6), new Pawn(PieceColor.Black) },
                { new Tuple<int, int>(2,6), new Pawn(PieceColor.Black) },
                { new Tuple<int, int>(3,6), new Pawn(PieceColor.Black) },
                { new Tuple<int, int>(4,6), new Pawn(PieceColor.Black) },
                { new Tuple<int, int>(5,6), new Pawn(PieceColor.Black) },
                { new Tuple<int, int>(6,6), new Pawn(PieceColor.Black) },
                { new Tuple<int, int>(7,6), new Pawn(PieceColor.Black) }
            };

            return board;
        }

        /// <summary>
        /// Returns a Piece given a board position
        /// </summary>
        /// <param name="pos"></param>
        /// <returns></returns>
        public Piece GetPiece(Tuple<int, int> pos)
        {
            Piece p;
            state.TryGetValue(pos, out p);
            return p;
        }
    }
}
