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
        private List<Core.Channel> channels = new List<Core.Channel>();
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
            foreach (Core.Channel chan in channels)
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

        void AddChannel(Core.Channel channel)
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
