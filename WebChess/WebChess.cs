using System;

namespace WebChess
{
    public class WebChess
    {
        public static void Main()
        {
            int servePort = 8080;

            Board b = Board.NewBoard();

            //DEPENDENCY INJECTION!
            var httpServer = new HttpServer(servePort, b);
            Console.WriteLine("Server is running");
            Console.ReadLine();
        }
    }
}