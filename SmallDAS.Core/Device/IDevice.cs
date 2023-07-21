using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallDAS.Core
{
    public interface IDevice
    {
        bool Initialize();
        List<Channel> GetChannels();
        bool Close();
    }
}
