using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerCore
{
    class Connector
    {
        public void Connect(IPEndPoint endPoint)
        {
            Socket socket = new Socket(endPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            SocketAsyncEventArgs args = new SocketAsyncEventArgs();
            args.Completed += OnConnectCompleted;
            args.RemoteEndPoint = endPoint;
        }
        void RegisterConnect(SocketAsyncEventArgs args)
        {
            bool pending = Socket.ConnectAsync(args);
        }
        void OnConnectCompleted(object sender, SocketAsyncEventArgs args)
        {

        }
    }
}
