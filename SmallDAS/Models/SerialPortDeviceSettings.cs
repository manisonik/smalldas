using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallDAS
{
    public class SerialPortDeviceSettings : IDeviceSettings
    {
        private SerialPortCommunication _serialPortCommunication;

        public string PortName { get; set; }
        public int BaudRate { get; set; }
        public int Parity { get; set; }
        public int StopBits { get; set; }
        public int DataBits { get; set; }
        public int Handshake { get; set; }
        public bool RtsEnable { get; set; }

        public SerialPortDeviceSettings(SerialPortCommunication serialPortCommunication)
        {
            _serialPortCommunication = serialPortCommunication;
        }

        public void Apply()
        {
            //_serialPortCommunication.
        }

        public void Reset()
        {
        }

        public void SetParameter(string name, object @value)
        {
            this.GetType().GetProperty(name).SetValue(this, @value, null);
        }

        public object GetParameter(string name)
        {
            return this.GetType().GetProperty(name).GetValue(this, null);
        }
    }
}
