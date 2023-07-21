using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SmallDAS
{
    [Serializable]
    [XmlRoot("SmallDAS.Configuration")]
    public class Configuration
    {
        private List<Device> devices = new List<Device>();

        [XmlArray("Devices"), XmlArrayItem(typeof(Device), ElementName = "Device")]
        public List<Device> Devices { get => devices; set => devices = value; }
    }
}
