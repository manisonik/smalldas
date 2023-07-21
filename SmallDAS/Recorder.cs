using SmallDAS.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SmallDAS
{
    class Recorder
    {
        private Timer timer = new Timer();
        private List<Channel> channels = new List<Channel>();
        private StreamWriter streamWriter;
        private string filepath = "";

        public Recorder(string filepath)
        {
            this.filepath = filepath;
        }

        void Start()
        {
            streamWriter = new StreamWriter(new FileStream(filepath, FileMode.Create));
            streamWriter.WriteLine("Output created by SmallDAS");

            // Write the header
            string header = "";
            string units = "";
            foreach (Channel chan in channels)
            {
                header += chan.Name + "\t";
                units += chan.Units + "\t";
            }

            streamWriter.WriteLine(header);
            streamWriter.WriteLine(units);

            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        void Stop()
        {
            timer.Stop();
            streamWriter.Close();
        }

        void AddChannel(Channel channel)
        {
            channels.Add(channel);
        }

        private void Timer_Tick(object sender, System.EventArgs e)
        {
            string row = "";
            foreach (var chan in channels)
            {
                if (chan.DataType == typeof(float))
                {
                    row += chan.Data() + "\t";
                }
                else if (chan.DataType == typeof(List<object>))
                {
                    List<object> data = (List<object>)chan.Data();
                    foreach (var d in data)
                    {
                    }
                }
            }
        }
    }
}
