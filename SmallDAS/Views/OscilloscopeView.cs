using OxyPlot;
using OxyPlot.Annotations;
using OxyPlot.Axes;
using OxyPlot.Series;
using SmallDAS.Visa;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SmallDAS
{
    public partial class OscilloscopeView : UserControl
    {
        private LineSeries c1LineSeries;
        private LineSeries c2LineSeries;
        private VisaDevice visa = new VisaDevice();
        private Timer timer = new Timer();

        private int tdivIndex = 0;
        private int vdivIndex = 0;

        private string[] tdivArray = new string[] { "2.5ns","5.00ns","10ns","25ns","50ns","100ns","250ns","500ns",
            "1.0us","2.50us","5.00us","10us","25us","50us","100us","250us","500us",
            "1.0ms","2.50us","5.00us","10ms","25ms","50ms","100ms","250ms","500ms",
            "1s","2.5s","5s","10s","25s","50s"
        };

        private string[] vdivArray = new string[] { "2mV","5mV","10mV","20mV","50mV","100mV","200mV","500mV",
            "1.0V", "2.0V", "5.0V", "10.0V",
        };

        float c1div = 0;
        float c2div = 0;
        float div = 0;
        float trdl = 0;
        float smrt = 0;
        float tivl = 0;
        float c1win = 0;
        float c2win = 0;
        float c1time = 0;
        float c2time = 0;
        private int prevX;

        public OscilloscopeView()
        {
            InitializeComponent();
            Configure();

            timer.Interval = 1;
            timer.Tick += Render;
            timer.Start();

            dataGridView1.Rows.Add("PKPK");
            dataGridView1.Rows.Add("MAX");
            dataGridView1.Rows.Add("MIN");
            dataGridView1.Rows.Add("AMPL");
            dataGridView1.Rows.Add("TOP");
            dataGridView1.Rows.Add("BASE");
            dataGridView1.Rows.Add("CMEAN");
            dataGridView1.Rows.Add("MEAN");
            dataGridView1.Rows.Add("RMS");
            dataGridView1.Rows.Add("CRMS");
            dataGridView1.Rows.Add("OVSN");
            dataGridView1.Rows.Add("FPRE");
            dataGridView1.Rows.Add("OVSP");
            dataGridView1.Rows.Add("RPRE");
            dataGridView1.Rows.Add("PER");
            dataGridView1.Rows.Add("FREQ");
            dataGridView1.Rows.Add("PWID");
            dataGridView1.Rows.Add("NWID");
            dataGridView1.Rows.Add("RISE");
            dataGridView1.Rows.Add("WID");
            dataGridView1.Rows.Add("DUTY");
            dataGridView1.Rows.Add("NDUTY");
        }

        private void SetParameters()
        {
            dataGridView1.Rows[0].Cells[1].Value = visa.pkpk;
            dataGridView1.Rows[1].Cells[1].Value = visa.max;
            dataGridView1.Rows[2].Cells[1].Value = visa.min;
            dataGridView1.Rows[3].Cells[1].Value = visa.ampl;
            dataGridView1.Rows[4].Cells[1].Value = visa.top;
            dataGridView1.Rows[5].Cells[1].Value = visa.vbase;
            dataGridView1.Rows[6].Cells[1].Value = visa.cmean;
            dataGridView1.Rows[7].Cells[1].Value = visa.mean;
            dataGridView1.Rows[8].Cells[1].Value = visa.rms;
            dataGridView1.Rows[9].Cells[1].Value = visa.crms;
            dataGridView1.Rows[10].Cells[1].Value = visa.ovsn;
            dataGridView1.Rows[11].Cells[1].Value = visa.fpre;
            dataGridView1.Rows[12].Cells[1].Value = visa.ovsp;
            dataGridView1.Rows[13].Cells[1].Value = visa.rpre;
            dataGridView1.Rows[14].Cells[1].Value = visa.per;
            dataGridView1.Rows[15].Cells[1].Value = visa.freq;
            dataGridView1.Rows[16].Cells[1].Value = visa.pwid;
            dataGridView1.Rows[17].Cells[1].Value = visa.nwid;
            dataGridView1.Rows[18].Cells[1].Value = visa.rise;
            dataGridView1.Rows[19].Cells[1].Value = visa.wid;
            dataGridView1.Rows[20].Cells[1].Value = visa.duty;
            dataGridView1.Rows[21].Cells[1].Value = visa.nduty;
        }

        private void Render(object sender, EventArgs e)
        {
            if (visa.IsConnected())
            {
                int c1counter = 0;
                int c2counter = 0;

                List<object> c1wf = visa.C1GetWaveFormData();
                List<object> c2wf = visa.C2GetWaveFormData();

                if (c1wf.Count > 0)
                {
                    c1LineSeries.Points.Clear();
                }

                if (c2wf.Count > 0)
                {
                    c2LineSeries.Points.Clear();
                }

                // Read parameters
                visa.Poll();

                float res = 0;
                if (float.TryParse(visa.vdelta, out res)) {

                    label3.Text = string.Format("Delta: {0}V", res);
                }

                SetParameters();

                c1div = (float)visa.C1GetVoltageDiv();
                c2div = (float)visa.C2GetVoltageDiv();
                div = (float)visa.GetTimeDivision();
                trdl = (float)visa.GetTriggerDelay();
                smrt = (float)visa.GetSampleRate();
                tivl = 1.0f / smrt;

                c1win = ((c1wf.Count) / (c1div / tivl)) / 2;
                c1time = trdl - (c1div * c1win);

                c2win = ((c2wf.Count) / (c2div / tivl)) / 2;
                c2time = trdl - (c2div * c2win);

                if (c1LineSeries.YAxis != null)
                {
                    c1LineSeries.YAxis.Minimum = Math.Min(-c1div * 4, -c2div * 4);
                    c1LineSeries.YAxis.Maximum = Math.Max(c1div * 4, c2div * 4);
                }

                /*for (int i = 0; i < 3; i++)
                {
                    (lineSeries.PlotModel.Annotations[i + 3] as LineAnnotation).Y = (i + 1) * c1div;
                    (lineSeries.PlotModel.Annotations[i + 6] as LineAnnotation).Y = (i + 1) * -c1div;
                }

                for (int i = 0; i < 3; i++)
                {
                    (lineSeries.PlotModel.Annotations[i + 3] as LineAnnotation).Y = (i + 1) * c1div;
                    (lineSeries.PlotModel.Annotations[i + 6] as LineAnnotation).Y = (i + 1) * -c1div;
                }*/

                foreach (float i in c1wf)
                {
                    c1LineSeries.Points.Insert(c1counter, new DataPoint(c1time, i));
                    c1time += tivl;
                    c1counter++;
                }

                foreach (float i in c2wf)
                {
                    c2LineSeries.Points.Insert(c2counter, new DataPoint(c2time, i));
                    c2time += tivl;
                    c2counter++;
                }

                plotView1.InvalidatePlot(true);
                plotView1.Invalidate();
            }
        }

        private void Configure()
        {
            visa.Initialize();

           var plotModel = new PlotModel
            {
                Title = "Sensor",
                TextColor = OxyColor.FromRgb(150, 150, 150),
                PlotAreaBorderColor = OxyColor.FromRgb(150, 150, 150),
                Background = OxyColor.FromRgb(50, 50, 50)

            };

            c1LineSeries = new LineSeries
            {
                BrokenLineColor = OxyColors.Automatic,
                Color = OxyColor.FromRgb(255, 255, 0),
            };

            c2LineSeries = new LineSeries
            {
                BrokenLineColor = OxyColors.Automatic,
                Color = OxyColors.Fuchsia
            };

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

            plotModel.Series.Add(c1LineSeries);
            plotModel.Series.Add(c2LineSeries);
            plotView1.Model = plotModel;
            plotView1.MouseWheel += PlotView1_MouseWheel;
            plotView1.MouseMove += PlotView1_MouseMove;

            c1LineSeries.PlotModel.Annotations.Add(new LineAnnotation() { Y = 0, StrokeThickness = 1, Color = OxyColors.DarkGray, Type = LineAnnotationType.Horizontal });
            c1LineSeries.PlotModel.Annotations.Add(new LineAnnotation() { Y = 0, StrokeThickness = 1, Color = OxyColors.DarkGray, Type = LineAnnotationType.Vertical });

            for (int i = 0; i < 8; i++)
            {
                c1LineSeries.PlotModel.Annotations.Add(new LineAnnotation() { Y = 0, StrokeThickness = 1, Color = OxyColor.FromRgb(40, 40, 40), Type = LineAnnotationType.Horizontal, LineStyle = LineStyle.Dot });
            }
        }

        private void PlotView1_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void PlotView1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (ModifierKeys == Keys.Shift)
            {
                float time = trdl + 10;
                Debug.WriteLine(time);
                visa.SetTriggerDelay(time);
            }
            else if (ModifierKeys == Keys.Control)
            {
                if (e.Delta > 0)
                {
                    vdivIndex++;
                    if (vdivIndex == vdivArray.Length - 1)
                    {
                        vdivIndex = 0;
                    }
                }
                else
                {
                    vdivIndex--;
                    if (vdivIndex < 0)
                    {
                        vdivIndex = 0;
                    }
                }

                visa.SetVoltageDivision(vdivArray[vdivIndex]);
            }
            else
            {
                if (e.Delta > 0)
                {
                    tdivIndex++;
                    if (tdivIndex == tdivArray.Length - 1)
                    {
                        tdivIndex = 0;
                    }
                }
                else
                {
                    tdivIndex--;
                    if (tdivIndex < 0)
                    {
                        tdivIndex = 0;
                    }
                }

                visa.SetTimeDivision(tdivArray[tdivIndex]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            visa.StartAcquisition();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            visa.ShowCursorVREL();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //visa.CursorAutoMode();
            visa.CursorSetVoltage(1, -1);
            //visa.HideCursor();
        }

        private void plotView1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
