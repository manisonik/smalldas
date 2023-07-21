using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SmallDAS
{
    public partial class WaveGen : Form
    {
        private PlotModel plotModel = new PlotModel
        {
            TextColor = OxyColor.FromRgb(150, 150, 150),
            PlotAreaBorderColor = OxyColor.FromRgb(150, 150, 150),
            Background = OxyColor.FromRgb(50, 50, 50),
            PlotMargins = new OxyThickness(25)
        };

        LineSeries lineSeries = new LineSeries();

        double sampleRate = 0.1;

        public WaveGen()
        {
            InitializeComponent();

            plotModel.Axes.Add(new LinearAxis()
            {
                Position = AxisPosition.Bottom,
                MajorGridlineColor = OxyColors.AntiqueWhite,
                MinorGridlineColor = OxyColors.AntiqueWhite,
                MinorTicklineColor = OxyColors.AntiqueWhite,
                TicklineColor = OxyColors.AntiqueWhite,
                IsZoomEnabled = false,
                IsPanEnabled = false,
            });

            plotModel.Axes.Add(new LinearAxis()
            {
                Position = AxisPosition.Left,
                MajorGridlineColor = OxyColors.AntiqueWhite,
                MinorGridlineColor = OxyColors.AntiqueWhite,
                MinorTicklineColor = OxyColors.AntiqueWhite,
                TicklineColor = OxyColors.AntiqueWhite,
                IsZoomEnabled = false,
                IsPanEnabled = false,
            });

            lineSeries = new LineSeries
            {
                BrokenLineColor = OxyColors.Automatic,
                Color = OxyColors.Fuchsia
            };

            plotModel.Series.Add(lineSeries);
            plotView1.Model = plotModel;
        }

        private void CreatePALSignal()
        {
            List<double> lum = new List<double>();
            List<double> cro = new List<double>();
            List<double> pal = new List<double>();

            // Create Sync Signal
            lum.AddRange(Pulse(0.38, 0.8, 2.35, 0.1, 0.1, 29.65, 32, 5));
            lum.AddRange(Pulse(0.38, 0.8, 27.3, 0.1, 0.1, 4.7, 32, 5));
            lum.AddRange(Pulse(0.38, 0.8, 3, 0.1, 0.1, 29, 32, 5)); // 480
            lum.AddRange(Pulse(0.38, 0.8, 4.7, 0.1, 0.1, 27.3, 32, 5));

            //Pulse(0.38, 0.8, 0, 0.1, 0.1, 32, 32, 1)

            cro.AddRange(Line(0, 495));
            cro.AddRange(Sine(.443, 0.1, 0, 5));
            cro.AddRange(Line(0, lum.Count - cro.Count));

            pal = Add(cro, lum);

            double time = 0;
            foreach (double y in pal)
            {
                lineSeries.Points.Add(new DataPoint(time++, y));
            }
        }

        List<double> Add(List<double> a, List<double> b)
        {
            List<double> data = new List<double>();
            for (int i = 0; i < b.Count; i++)
            {
                data.Add(a[i] + b[i]);
            }

            return data;
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private double lerp(double x1, double y1, double x2, double y2, double x)
        {
            return y1 + (x - x1) * (y2 - y1) / (x2 - x1);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
           
        }

        private void WaveGen_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        List<double> Line(double on, double time)
        {
            List<double> data = new List<double>();
            for (double i = 0; i < time; i += sampleRate)
            {
                data.Add(on);
            }

            return data;
        }

        List<double> Sine(double freq, double amplitude, double phi, double ncycles)
        {
            List<double> data = new List<double>();
            for (double i = 0; i < 1 / freq * ncycles; i += sampleRate)
            {
                data.Add(amplitude * Math.Sin(2 * Math.PI * freq * i + phi));
            }

            return data;
        }

        List<double> Pulse(double initial, double on, double tdelay, double trise, double tfall, double ton, double tperiod, double ncycle)
        {
            List<double> data = new List<double>();

            double time = 0;
            for (int j = 0; j < ncycle; j++)
            {
                // Set the delay with initial value
                for (double i = 0; i < tdelay; i += sampleRate)
                {
                    data.Add(initial);
                    time += sampleRate;
                }

                // Interpolate to the on state
                for (double i = 0; i < trise; i += sampleRate)
                {
                    data.Add(lerp(0, initial, trise, on, i));
                    time += sampleRate;
                }

                // On state
                for (double i = 0; i < ton; i += sampleRate)
                {
                    data.Add(on);
                    time += sampleRate;
                }

                // Interpolate to the initial state
                for (double i = 0; i < tfall; i += sampleRate)
                {
                    data.Add(lerp(0, on, tfall, initial, i));
                    time += sampleRate;
                }

                // Fill in the remaining
                double lastTime = time;
                for (double i = lastTime; i < tperiod * (j + 1); i += sampleRate)
                {
                    data.Add(initial);
                    time += sampleRate;
                }
            }

            return data;
        }

        private void treeView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                plotModel.Series.Remove((Series)treeView1.SelectedNode.Tag);

                TreeNode selectedNode = treeView1.SelectedNode;
                treeView1.Nodes.Remove(selectedNode);

                plotView1.InvalidatePlot(true);
            }
        }

        private void treeView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(treeView1, treeView1.SelectedNode.Bounds.Location);
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
         
        }

        private void WaveGen_Load(object sender, EventArgs e)
        {
            CreatePALSignal();
            plotView1.InvalidatePlot(true);
        }
    }
}
