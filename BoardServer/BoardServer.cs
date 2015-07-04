using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Sockets;
using System.IO;

namespace WebChess
{
    public class BoardServer
    {
        public Board board { get; set; }

        private readonly Socket _socket;
        private readonly NetworkStream _networkStream;
        private readonly MemoryStream _memoryStream = new MemoryStream();
        private readonly StreamReader _streamReader;
        private readonly string _serverName = "WebChess";

        public BoardServer(Board b)
        {
            board = b;
        }

        public async Task<int> ServeBoard()
        {
            string json = JsonConvert.SerializeObject(board.GetState());
            byte[] data;
            string responseCode = "200";
            string contentType = "application/json";
            string header = string.Format("HTTP/1.1 {0}\r\n"
                                          + "Server: {1}\r\n"
                                          + "Content-Length: {2}\r\n"
                                          + "Content-Type: {3}\r\n"
                                          + "Keep-Alive: Close\r\n"
                                          + "\r\n",
                                          responseCode, _serverName, json.Length, contentType);

            var headerBytes = Encoding.ASCII.GetBytes(header);
            data = Encoding.ASCII.GetBytes(json);

            await _networkStream.WriteAsync(headerBytes, 0, headerBytes.Length);
            await _networkStream.WriteAsync(data, 0, data.Length);
            await _networkStream.FlushAsync();
            // Close connection (we don't support keep-alive)
            _networkStream.Dispose();

            return 0;
        }
    }
}
