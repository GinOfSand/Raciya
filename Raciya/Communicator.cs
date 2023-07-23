using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Raciya
{
    public class Communicator
    {
        public Socket Socket { get; set; }

        public Communicator(Socket socket)
        {
            Socket = socket;
        }
        public void SendMessage(string message)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(message);
            Socket.Send(buffer);
        }
        
        public string Recive()
        {
            byte[] buffer = new byte[1024];
            int received_bytes_count = Socket.Receive(buffer);
            return Encoding.UTF8.GetString(buffer, 0, received_bytes_count);
            
        }
    }
}
