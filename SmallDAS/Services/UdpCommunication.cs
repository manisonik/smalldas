using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallDAS.Services
{
    internal class UdpCommunication : ICommunication
    {
        public bool Connect()
        {
            return true;
        }

        public bool Disconnect()
        {
            return true;
        }

        public string Receive()
        {
            return string.Empty;
        }

        public bool Send(string message)
        {
            return true;
        }
    }
}
