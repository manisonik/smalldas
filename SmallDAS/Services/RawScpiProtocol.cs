using Ivi.Visa;
using NationalInstruments.Visa;
using System.Collections.Generic;

namespace SmallDAS
{
    public class RawScpiProtocol : IProtocol
    {
        private List<Channel> channels = new List<Channel>();
        public List<Channel> Channels { get => channels; set => channels = value; }

        /// <summary>
        /// Initializes 
        /// </summary>
        public RawScpiProtocol()
        {
        }

        ~RawScpiProtocol()
        {
        }

        public void Process(string message)
        {
            string[] commands = message.Trim().Split(';');
            foreach (string command in commands)
            {
                bool isQuery = false;
                string[] s = command.Split(' ', ',');

                if (s[0].Contains("?")) { isQuery = true; }

                foreach (Channel channel in channels)
                {
                    if (channel.Equals(s[0].ToUpper()))
                    {

                    }
                }
            }
        }
    }
}
