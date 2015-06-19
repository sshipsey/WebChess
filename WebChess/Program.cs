using System;

namespace WebChess
{
    class Program
    {
        static void Main()
        {
            Board b = Board.NewBoard();

            Piece p = new Rook(PieceColor.White);
            int x = (int)p.color;

            Piece s = new Rook(PieceColor.Black);
            int y = (int)s.color;



            Console.Write("");
        }
    }
}