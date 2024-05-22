using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System;
using System.Diagnostics;
using System.IO;
using System.IO.Ports;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Xml;
using OxyPlot.WindowsForms;
using SmallDAS.Services;
using System.Runtime.Remoting.Channels;

namespace SmallDAS
{
    public partial class Form1 : Form
    {
        private LineSeries lineSeries;
        private ScatterSeries scatterSeriesXY;
        private ScatterSeries scatterSeriesXZ;
        private ScatterSeries scatterSeriesYZ;
        private SensorData sensorData = new SensorData();
        private List<Device> deviceList = new List<Device>();
        private List<double> filterData = new List<double>();
        private Configuration _config = new Configuration();

        public Form1()
        {
            InitializeComponent();
            LoadConfiguration();
            LoadDevices();
        }

        private void LoadDevices()
        {
            foreach (var device in _config.Devices) {
                IProtocol protocol = null;
                ICommunication communication = null;
                IDeviceSettings deviceSettings = null;

                // Select communication
                if (device.CommunicationType == "TCP")
                {           
                     communication = new TcpCommunication(device.Name, 8080);
                }
                else if (device.CommunicationType == "Visa")
                {
                    var visa = new VisaCommunication(device.Name, 8080);
                    protocol = visa;
                    communication = visa;
                }
                else if (device.CommunicationType == "SerialPort")
                {
                    var serialPortCommunication = new SerialPortCommunication();
                    deviceSettings = new SerialPortDeviceSettings(serialPortCommunication);
                    communication = serialPortCommunication;
                }

                // Select protocol
                if (device.DeviceProtocol == "RawScpi")
                {
                     protocol = new RawScpiProtocol();
                }

                device.Initialize(protocol, communication, deviceSettings);
            }
        }

        private void ConnectDevices()
        {
            foreach (var device in _config.Devices)
            {
                if (device.Enabled)
                {
                    if (device.Connect() == true)
                    {

                    }
                }
            }
        }

        private void LoadConfiguration()
        {
            try
            {
                if (File.Exists("SmallDAS.Configuration.xml"))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(Configuration));
                    using (XmlReader reader = XmlReader.Create("SmallDAS.Configuration.xml"))
                    {
                        _config = (Configuration)ser.Deserialize(reader);
                    }
                }
                else
                {
                    var fs = File.Create("SmallDAS.Configuration.xml");
                    fs.Close();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Customize menu strip as a dark theme
            menuStrip1.Renderer = new UserToolStripRenderer(new UserColorTable());

            ViewSelector viewSelector = new ViewSelector();
            viewSelector.Dock = DockStyle.Fill;
            splitContainer3.Panel1.Controls.Add(viewSelector);
        }

        private void ControlView1_CommandExecuted(object sender, ControlView.CommandExecutedEventArgs e)
        {

        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                SerialPort sp = (SerialPort)sender;
                string inData = sp.ReadLine();

                string data = Regex.Replace(inData, @"\r", "");
                string[] s = data.Split(' ');
            }
            catch (Exception ex) {}
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            scatterSeriesXY.Points.Clear();
            scatterSeriesXZ.Points.Clear();
            scatterSeriesYZ.Points.Clear();
        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeviceView devices = new DeviceView(_config);
            if (devices.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                PwlView pwlView = new PwlView();
                PlotView plotView = pwlView.GetPlotView();

                var pM = new PlotModel
                {
                    Title = "Pwl View",
                    TextColor = OxyColor.FromRgb(150, 150, 150),
                    PlotAreaBorderColor = OxyColor.FromRgb(150, 150, 150),
                    Background = OxyColor.FromRgb(50, 50, 50)

                };

                var lS = new LineSeries
                {
                    BrokenLineColor = OxyColors.Automatic,
                    Color = OxyColor.FromRgb(150, 150, 150),
                };

                pM.Axes.Add(new LinearAxis()
                {
                    Position = AxisPosition.Bottom,
                    MajorGridlineColor = OxyColors.AntiqueWhite,
                    MinorGridlineColor = OxyColors.AntiqueWhite,
                    MinorTicklineColor = OxyColors.AntiqueWhite,
                    TicklineColor = OxyColors.AntiqueWhite
                });

                pM.Axes.Add(new LinearAxis()
                {
                    Position = AxisPosition.Left,
                    MajorGridlineColor = OxyColors.AntiqueWhite,
                    MinorGridlineColor = OxyColors.AntiqueWhite,
                    MinorTicklineColor = OxyColors.AntiqueWhite,
                    TicklineColor = OxyColors.AntiqueWhite
                });

                pM.Series.Add(lS);
                plotView.Model = pM;

                using (StreamReader sr = new StreamReader(ofd.FileName))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] s = sr.ReadLine().Split(',');
                        if (s.Length == 2)
                        {
                            lS.Points.Add(new DataPoint(double.Parse(s[0]), double.Parse(s[1])));
                        }
                    }
                }

                plotView.Invalidate();
                pwlView.Show();
            }
        }

        private void waveGenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WaveGen waveGen = new WaveGen();
            waveGen.Show();
        }

        private void devicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeviceView devices = new DeviceView(_config);
            devices.Show();
        }

        private void splitContainer3_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void startMeasure_Click(object sender, EventArgs e)
        {
            foreach (var device in _config.Devices)
            {
                device.Connect();
            }
        }
    }
}
