using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Raciya
{
    internal class ClientService : IDisposable
    {
        public Socket client { get; set; }
        public Communicator commun { get; set; }
        public ClientService(string ipServ, int port)
        {
            client = new Socket(AddressFamily.InterNetwork,
                        SocketType.Stream, ProtocolType.IP);
            IPAddress serverIp = IPAddress.Parse(ipServ);
            IPEndPoint serverEndPoint = new IPEndPoint(serverIp, port);
            commun = new Communicator(client);
            client.Connect(serverEndPoint);
        }

        public void Dispose()
        {
            client?.Dispose();
        }
    }
}
