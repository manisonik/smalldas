using System.Collections.Generic;
using System.Xml.Serialization;

namespace SmallDAS
{
    [XmlRoot("Device")]
    public class Device
    {
        private IProtocol _protocol;
        private ICommunication _communication;
        private IDeviceSettings _settings;
        private object _lock = new object();

        [XmlIgnore]
        public IProtocol Protocol { get => _protocol; set => _protocol = value; }

        [XmlIgnore]
        public ICommunication Communication { get => _communication; set => _communication = value; }

        [XmlIgnore]
        public IDeviceSettings Settings { get => _settings; set => _settings = value; }

        [XmlElement(ElementName = "Channels")]
        public List<Channel> Channels { get; set; } = new List<Channel>();

        [XmlElement(ElementName = "Parsers")]
        public List<Parser> Parsers { get; set; } = new List<Parser>();

        [XmlElement(ElementName = "Enabled")]
        public bool Enabled { get; set; }

        [XmlElement(ElementName = "Timeout")]
        public string Timeout { get; set; }

        [XmlElement(ElementName = "CommunicationType")]
        public string CommunicationType { get; set; }

        [XmlElement(ElementName = "DeviceProtocol")]
        public string DeviceProtocol { get; set; }

        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }

        public void Initialize(IProtocol protocol, ICommunication communcation, IDeviceSettings settings)
        {
            _protocol = protocol;
            _communication = communcation;
            _settings = settings;
        }

        public void Apply()
        {
            _settings?.Apply();
        }

        public void Reset()
        {
            _settings?.Reset();
        }

        public void SetParameter(string name, object value)
        {
            _settings?.SetParameter(name, value);
        }

        public object GetParameter(string name)
        {
            return _settings?.GetParameter(name);
        }

        public bool? Connect()
        {
            return _communication?.Connect();
        }

        public bool? Send(string text)
        {
            return _communication?.Send(text);
        }

        public string Receive()
        {
            return _communication?.Receive();
        }

        /// <summary>
        /// Thread-safe function to send and receive command.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public string SendReceive(string text)
        {
            string recv = string.Empty;

            lock (_lock)
            {
                bool? retVal = Send(text);
                if (retVal == true)
                {
                    recv = Receive();
                }
            }

            return recv;
        }
    }
}
