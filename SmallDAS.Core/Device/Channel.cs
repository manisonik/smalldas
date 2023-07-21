using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallDAS.Core
{
    public class Channel
    {
        public delegate object ChannelData();
        private string units;
        private ChannelData data;
        private string name;

        public Type DataType { get; set; }
        public string Units { get => units; set => units = value; }
        public ChannelData Data { get => data; set => data = value; }
        public string Name { get => name; set => name = value; }
    }
}
