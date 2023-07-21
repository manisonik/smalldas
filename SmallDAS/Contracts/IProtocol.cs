using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallDAS
{
    public interface IProtocol
    {
        void Connect();
        void Disconnect();
        void Send(string text);
        string Receive();
    }
}
