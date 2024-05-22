using Ivi.Visa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace SmallDAS.Services
{
    public class TcpCommunication : ICommunication
    {
        private Socket _socket;
        private IPAddress _address;
        private int _port;
        private char _terminator;

        public TcpCommunication(string address, int port)
        {
            IPAddress ipAddress;
            if (IPAddress.TryParse(address, out ipAddress))
            {
                _address = ipAddress;
            }
            _port = port;
            _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            _socket.ReceiveTimeout = 2000;
        }

        public bool Connect()
        {
            try
            {
                _socket.Connect(_address, _port);
            }
            catch (Exception ex)
            {

            }

            return true;
        }

        public bool Disconnect()
        {
            if (_socket != null)
            {
                _socket.Close();
            }

            return true;
        }

        public string Receive()
        {
            var buffer = new byte[128];
            var bytes = 0;

            string sb = string.Empty;
            while (true)
            { 
                try
                {
                    bytes = _socket.Receive(buffer, buffer.Length, SocketFlags.None);
                    if (bytes == 0)
                        break;

                    sb += Encoding.ASCII.GetString(buffer, 0, bytes);
                }
                catch (Exception)
                {
                }
            }

            return sb;
        }

        public bool Send(string message)
        {
            try
            {
                _socket.Send(Encoding.ASCII.GetBytes(message));
            }
            catch (Exception)
            {

            }

            return true;
        }
    }
}
