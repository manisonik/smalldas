using OxyPlot.WindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmallDAS
{
    public partial class PwlView : Form
    {
        public PwlView()
        {
            InitializeComponent();
        }

        public PlotView GetPlotView()
        {
            return plotView1;
        }
    }
}
