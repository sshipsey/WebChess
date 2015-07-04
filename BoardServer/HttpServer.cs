using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WebChess
{
    public class HttpServer
    {
        public readonly int Port;
        private readonly TcpListener _tcpListener;
        private readonly Task _listenTask;
        private readonly string CurrentJSON;

        /// <summary>
        /// Constructor for string type
        /// </summary>
        /// <param name="port"></param>
        /// <param name="j"></param>
        public HttpServer(int port, string j)
        {
            Port = port;
            CurrentJSON = j;
            _tcpListener = new TcpListener(IPAddress.Any, Port);
            _tcpListener.Start();

            _listenTask = Task.Factory.StartNew(() => ListenLoop());
        }

        /// <summary>
        /// Constructor for board type
        /// </summary>
        /// <param name="port"></param>
        /// <param name="b"></param>
        public HttpServer(int port, Board b)
        {
            Port = port;
            CurrentJSON = JsonConvert.SerializeObject(b.GetState(), Formatting.Indented);
            _tcpListener = new TcpListener(IPAddress.Any, Port);
            _tcpListener.Start();

            _listenTask = Task.Factory.StartNew(() => ListenLoop());
        }

        public async void ListenLoop()
        {
            for (; ;)
            {

                var socket = await _tcpListener.AcceptSocketAsync();
                if (socket == null)
                    break;

                var client = new Client(socket);
                await client.SendJSON(CurrentJSON);
            }
        }
    }
}