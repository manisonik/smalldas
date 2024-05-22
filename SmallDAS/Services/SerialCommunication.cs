using System;
using System.IO.Ports;
using System.Text;

namespace SmallDAS.Services
{
    public class SerialCommunication : ICommunication
    {
        private SerialPort _serialPort;
        private StringBuilder _sb;

        public SerialCommunication(string port, int baudRate = 9600, Parity parity = Parity.None)
        {
            _serialPort = new SerialPort(port);
            _serialPort.BaudRate = 9600;
            _serialPort.Parity = Parity.None;
            _serialPort.StopBits = StopBits.One;
            _serialPort.DataBits = 8;
            _serialPort.Handshake = Handshake.None;
            _serialPort.RtsEnable = true;
            _serialPort.ReceivedBytesThreshold = 8;
            _serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            // Set the read/write timeouts
            _serialPort.ReadTimeout = 500;
            _serialPort.WriteTimeout = 500;
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                SerialPort sp = (SerialPort)sender;
                _sb.Append(sp.ReadLine());
            }
            catch (Exception ex) 
            { 
            }
        }

        public bool Connect()
        {
            try
            {
                _serialPort.Open();
                return true;
            }
            catch(Exception ex) 
            { 
                
            }

            return false;
        }

        public bool Disconnect()
        {
            try
            {
                _serialPort.Close();
                return true;
            }
            catch (Exception ex)
            {

            }

            return false;
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
