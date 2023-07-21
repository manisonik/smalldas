using System.Xml.Serialization;

namespace SmallDAS
{
    [XmlRoot("Device")]
    public class Device
    {
        private IProtocol _protocol;

        public void Initialize(IProtocol protocol)
        {
            _protocol = protocol;
        }

        public void Connect()
        {
            _protocol?.Connect();
        }

        public void Send(string text)
        {
            _protocol?.Send(text);
        }

        public string Receive()
        {
            return _protocol?.Receive();
        }

        [XmlElement(ElementName = "Enabled")]
        public bool Enabled { get; set; }

        [XmlElement(ElementName = "Timeout")]
        public string Timeout { get; set; }

        [XmlElement(ElementName = "Protocol")]
        public string Protocol { get; set; }

        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }
    }
}
