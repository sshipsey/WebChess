using System.Collections.Generic;

namespace WebChess
{
    public class Board
    {
        private Dictionary<Position, Piece> state;

        /// <summary>
        /// Getter for board state
        /// </summary>
        /// <returns></returns>
        public Dictionary<Position, Piece> GetState()
        {
            return state;
        }

        /// <summary>
        /// Initialize default board state
        /// </summary>
        /// <returns></returns>
        public static Board NewBoard()
        {
            var board = new Board();

            board.state = new Dictionary<Position, Piece>
            {
                //White's Pieces
                { new Position(0,0), new Rook(PieceColor.White) },
                { new Position(1,0), new Knight(PieceColor.White) },
                { new Position(2,0), new Bishop(PieceColor.White) },
                { new Position(3,0), new King(PieceColor.White) },
                { new Position(4,0), new Queen(PieceColor.White) },
                { new Position(5,0), new Bishop(PieceColor.White) },
                { new Position(6,0), new Knight(PieceColor.White) },
                { new Position(7,0), new Rook(PieceColor.White) },
                { new Position(0,1), new Pawn(PieceColor.White) },
                { new Position(1,1), new Pawn(PieceColor.White) },
                { new Position(2,1), new Pawn(PieceColor.White) },
                { new Position(3,1), new Pawn(PieceColor.White) },
                { new Position(4,1), new Pawn(PieceColor.White) },
                { new Position(5,1), new Pawn(PieceColor.White) },
                { new Position(6,1), new Pawn(PieceColor.White) },
                { new Position(7,1), new Pawn(PieceColor.White) },

                //Black's Pieces
                { new Position(0,7), new Rook(PieceColor.Black) },
                { new Position(1,7), new Knight(PieceColor.Black) },
                { new Position(2,7), new Bishop(PieceColor.Black) },
                { new Position(3,7), new Queen(PieceColor.Black) },
                { new Position(4,7), new King(PieceColor.Black) },
                { new Position(5,7), new Bishop(PieceColor.Black) },
                { new Position(6,7), new Knight(PieceColor.Black) },
                { new Position(7,7), new Rook(PieceColor.Black) },
                { new Position(0,6), new Pawn(PieceColor.Black) },
                { new Position(1,6), new Pawn(PieceColor.Black) },
                { new Position(2,6), new Pawn(PieceColor.Black) },
                { new Position(3,6), new Pawn(PieceColor.Black) },
                { new Position(4,6), new Pawn(PieceColor.Black) },
                { new Position(5,6), new Pawn(PieceColor.Black) },
                { new Position(6,6), new Pawn(PieceColor.Black) },
                { new Position(7,6), new Pawn(PieceColor.Black) }
            };

            return board;
        }

        /// <summary>
        /// Returns a Piece given a board position
        /// </summary>
        /// <param name="pos"></param>
        /// <returns></returns>
        public Piece GetPiece(Position pos)
        {
            Piece p;
            state.TryGetValue(pos, out p);
            return p;
        }

        /// <summary>
        /// Prints board to screen
        /// </summary>
        /// <returns></returns>
        public string Print()
        {
            string retVal = "";



            return retVal;
        }


    }
}
