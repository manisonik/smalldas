using Ivi.Visa;
using NationalInstruments.Visa;
using System;
using System.Windows.Forms;

namespace SmallDAS.Services
{
    public class VisaCommunication : ICommunication, IProtocol
    {
        private ResourceManager _resourceManager = new ResourceManager();
        private MessageBasedSession _messageSession;
        private string _address;
        private int _timeout;

        public VisaCommunication(string address, int timeout = 2000)
        {
            _address = address;
            _timeout = timeout;
        }

        ~VisaCommunication() 
        {
            if (_messageSession != null)
            {
                _messageSession.Dispose();
            }
        }

        public bool Connect()
        {
            try
            {
                _messageSession = (MessageBasedSession)_resourceManager.Open(_address);
                _messageSession.TimeoutMilliseconds = _timeout;

                return true;
            }
            catch (NativeVisaException e)
            {

            }

            return false;
        }

        public bool Disconnect()
        {
            try
            {
                if (_messageSession != null)
                {
                    _messageSession.UnlockResource();
                }

                return true;
            }
            catch (Exception e)
            {

            }

            return false;
        }

        public void Process(string message)
        {
            throw new NotImplementedException();
        }

        public string Receive()
        {
            var recv = string.Empty;

            try
            {
                recv = _messageSession?.RawIO.ReadString();
            }
            catch (Exception e)
            {

            }

            return recv;
        }

        public bool Send(string message)
        {
            try
            {
                _messageSession?.RawIO.Write(message);

                return true;
            }
            catch (Exception e)
            {

            }

            return false;
        }
    }
}
