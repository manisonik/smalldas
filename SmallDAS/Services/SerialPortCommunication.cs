using System;
using System.IO;
using System.IO.Ports;
using System.Text;

namespace SmallDAS
{
    public class SerialPortCommunication : ICommunication
    {
        private SerialPort _serialPort = new SerialPort();
        private MemoryStream _stream = new MemoryStream();

        public SerialPortCommunication() {
            _serialPort.PortName = "COM1";
            _serialPort.BaudRate = 9600;
            _serialPort.Parity = Parity.None;
            _serialPort.StopBits = StopBits.One;
            _serialPort.DataBits = 8;
            _serialPort.Handshake = Handshake.None;
            _serialPort.RtsEnable = true;
            _serialPort.ReceivedBytesThreshold = 8;
            _serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                SerialPort sp = (SerialPort)sender;
                string inData = sp.ReadLine();

                int numBytes = sp.BytesToRead;
                if (numBytes == 0)
                    return;

                byte[] buffer = new byte[numBytes];
                sp.Read(buffer, 0, buffer.Length);
                _stream.Write(buffer, 0, buffer.Length);
            }
            catch (Exception) { }
        }

        public bool Connect()
        {
            try
            {
                if (!_serialPort.IsOpen)
                {
                    _serialPort.Open();
                    _serialPort.RtsEnable = true;
                    return true;
                }
            } catch (Exception) { }

            return false;
        }

        public bool Disconnect()
        {
            try
            {
                if (_serialPort.IsOpen)
                {
                    _serialPort.Close();
                    return true;
                }
            }
            catch(Exception) { }

            return false;
        }

        public string Receive()
        {
            try
            {
                var buffer = _stream.GetBuffer();
                return Encoding.UTF8.GetString(buffer, 0, buffer.Length);
            }
            catch (Exception) { }

            return string.Empty;
        }

        public bool Send(string message)
        {
            try
            {
                _serialPort.Write(message);
                return true;
            }
            catch (Exception) { }

            return false;
        }
    }
}
