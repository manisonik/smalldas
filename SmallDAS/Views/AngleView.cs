using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.IO.Ports;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using System.Drawing.Drawing2D;

namespace SmallDAS
{
    public partial class AngleView : UserControl
    {
        private float angle = 0;

        public AngleView()
        {
            InitializeComponent();
        }

        private void AngleView_Load(object sender, EventArgs e)
        {
        }

        public void UpdateAngle(float angle)
        {
            this.angle = angle;
            Invalidate();
        }

        private void AngleView_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            int width = this.Width;
            int height = this.Height;

            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            e.Graphics.DrawString(angle.ToString(), drawFont, drawBrush, 0, 0);

            float min = Math.Min(width, height);
            Pen myPen = new Pen(Color.Gainsboro);
            e.Graphics.DrawEllipse(myPen, 0, 0, min - 5, min - 5);

            float x = min / 2.0f;
            float y = min / 2.0f;

            Matrix result = new Matrix();
            result.RotateAt(angle, new PointF(x, y));
            e.Graphics.Transform = result;

            e.Graphics.DrawLine(myPen, new PointF(x - min / 2.0f, y), new PointF(x + min / 2.0f - 5, y));
        }

        private void AngleView_Resize(object sender, EventArgs e)
        {

        }
    }
}
