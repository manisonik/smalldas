using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallDAS
{
    public interface ICommunication
    {
        bool Connect();
        bool Disconnect();
        bool Send(string message);
        string Receive();
    }
}
