using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Raciya
{
    internal class ServerService : IDisposable
    {
        public Socket Server { get; set; }
        public Socket Client { get; set; }
        public Communicator Communicator { get; set; }
        public ServerService(string ip, int port)
        {
            // 1. Создать сокет
            Server = new Socket(AddressFamily.InterNetwork,
                SocketType.Stream, ProtocolType.IP);
            IPAddress serverIP = IPAddress.Parse(ip);   
            IPEndPoint serEP = new IPEndPoint(serverIP, port);
            Communicator = new Communicator(Server);
            Server.Bind(serEP);
            Server.Listen(1);
            Client.Accept();
        }

        public void Dispose()
        {
            Client.Close();
            Server.Close();
        }

        
    }
}
