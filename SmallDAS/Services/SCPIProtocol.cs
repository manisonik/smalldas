using Ivi.Visa;
using NationalInstruments.Visa;

namespace SmallDAS
{
    public class SCPIProtocol : IProtocol
    {
        private ResourceManager _resourceManager = new ResourceManager();
        private MessageBasedSession _messageSession;
        private string _address;
        private int _timeout;

        /// <summary>
        /// Initializes 
        /// </summary>
        public SCPIProtocol(string address, int timeout = 1000)
        {
            _address = address;
            _timeout = timeout;
        }

        ~SCPIProtocol()
        {
            if (_messageSession != null)
            {
                _messageSession.Dispose();
            }
        }

        public void Connect()
        {
            try
            {
                _messageSession = (MessageBasedSession)_resourceManager.Open(_address);
                _messageSession.TimeoutMilliseconds = _timeout;
            }
            catch (NativeVisaException e)
            {

            }
        }

        public void Disconnect()
        {
            if (_messageSession != null)
            {
                _messageSession.UnlockResource();
            }
        }

        public string Receive()
        {
            return _messageSession?.RawIO.ReadString();
        }

        public void Send(string text)
        {
            _messageSession?.RawIO.Write(text);
        }
    }
}
