using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebChess
{
    class Client
    {
        private readonly Socket _socket;
        private readonly NetworkStream _networkStream;
        private readonly MemoryStream _memoryStream = new MemoryStream();
        private readonly StreamReader _streamReader;
        private readonly string _serverName = "WebChess";

        public Client(Socket socket)
        {
            _socket = socket;
            _networkStream = new NetworkStream(socket, true);
            _streamReader = new StreamReader(_memoryStream);
        }


        public async Task<int> SendJSON(string json)

        {
            //Don't have null JSON
            if (json == null)
            {
                json = "No data recieved";
            }


            // Get info and assemble header
            byte[] data;
            string responseCode = "202";
            string contentType = "application/json";


            string header = string.Format("HTTP/1.1 {0}\r\n"
                                          + "Server: {1}\r\n"
                                          + "Content-Length: {2}\r\n"
                                          + "Content-Type: {3}\r\n"
                                          + "Keep-Alive: Close\r\n"
                                          + "Access-Control-Allow-Origin: *\r\n"
                                          + "\r\n",
                                          responseCode, _serverName, json.Length, contentType);



            // Send header & data
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
