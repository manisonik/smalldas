using System;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using NationalInstruments.Visa;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using OxyPlot;

namespace SmallDAS
{
    public partial class ViewSelector : UserControl
    {
        enum ResizeFlag
        {
            None = 0,
            Right = 1,
            Bottom = 2,
            Left = 3,
            Top = 4,
            Move
        }

        private ResizeFlag _resizeFlag = ResizeFlag.None;
        private Point _firstPoint;
        private Point _currentLocation;

        public ViewSelector()
        {
            InitializeComponent();
            contextMenuStrip1.Renderer = new UserToolStripRenderer(new UserColorTable());
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            e.Control.MouseMove += OnMouseMove;
            e.Control.MouseDown += OnMouseDown;
            e.Control.MouseUp += OnMouseUp;
            base.OnControlAdded(e);
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position);
            }
            else if (e.Button == MouseButtons.Left)
            {
            }
            base.OnMouseClick(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            foreach (Control control in Controls)
            {
                var cr = RectangleToClient(control.ClientRectangle);
                var rc = new Rectangle(
                    control.Location.X,
                    control.Location.Y,
                    control.Width,
                    control.Height
                );

                if (_resizeFlag != ResizeFlag.None)
                {
                    using (Pen pen = new Pen(Color.CadetBlue, 2))
                    {
                        pen.DashStyle = DashStyle.Solid;
                        g.DrawRectangle(pen, rc);
                    }
                }
                else
                {
                    using (Pen pen = new Pen(Color.CadetBlue, 2))
                    {
                        pen.DashStyle = DashStyle.Dash;
                        g.DrawRectangle(pen, rc);
                    }
                }

            }
            base.OnPaint(e);
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (sender is ViewSelector)
            {
                Cursor = Cursors.Default;
            }
            else
            {
                Point pt = PointToClient(Cursor.Position);
                Control c = sender as Control;
                Rectangle rc = new Rectangle(c.Location, c.Size);
                rc.Inflate(-4, -4);

                if (rc.Contains(pt))
                {
                    Cursor = Cursors.Hand;
                }
                else if (pt.X > rc.X + rc.Width)
                {
                    Cursor = Cursors.SizeWE;
                }
                else if (pt.Y > rc.Y + rc.Height)
                {
                    Cursor = Cursors.SizeNS;
                }
                else if (pt.X < rc.X)
                {
                    Cursor = Cursors.SizeWE;
                }
                else if (pt.Y < rc.Y)
                {
                    Cursor = Cursors.SizeNS;
                }
                else
                {
                    Cursor = Cursors.Default;
                }

                switch (_resizeFlag)
                {
                    case ResizeFlag.Move:
                        {
                            // Get the difference between the two points
                            int xDiff = _firstPoint.X - pt.X;
                            int yDiff = _firstPoint.Y - pt.Y;

                            // Set the new point
                            int x = _currentLocation.X - xDiff;
                            int y = _currentLocation.Y - yDiff;

                            // Clamp
                            if (x < 1) x = 1;
                            if (y < 1) y = 1;
                            if (x > Width - c.Width - 1) x = Width - c.Width - 1;
                            if (y > Height - c.Height - 1) y = Height - c.Height - 1;
                            c.Location = new Point(x, y);
                            c.Invalidate();
                            Invalidate();
                        }
                        break;
                    case ResizeFlag.Right:
                        {
                            int w = pt.X - c.Location.X;
                            int h = c.Height;
                            c.Size = new Size(w, h);
                            Invalidate();
                            c.Invalidate();
                        }
                        break;
                    case ResizeFlag.Bottom:
                        {
                            int w = c.Width;
                            int h = pt.Y - c.Location.Y;
                            c.Size = new Size(w, h);
                            Invalidate();
                            c.Invalidate();
                        }
                        break;
                    case ResizeFlag.Left:
                        {
                            //int h = Size.Height;
                            //int r = Location.X + Size.Width;
                            // Location = new Point(cpt.X, Location.Y);
                            // Size = new Size(r - cpt.X, h);
                            //Invalidate(true);
                        }
                        break;
                    case ResizeFlag.Top:
                        {
                            //int w = Size.Width;
                            //int b = Location.Y + Size.Height;
                            //Location = new Point(Location.X, cpt.Y);
                            //Size = new Size(w, b - cpt.Y);
                            //Invalidate(true);
                        }
                        break;
                }
            }
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point pt = PointToClient(Cursor.Position);
                Control c = sender as Control;
                Rectangle rc = new Rectangle(c.Location, c.Size);
                rc.Inflate(-4, -4);

                if (rc.Contains(pt))
                {
                    _firstPoint = pt;
                    _currentLocation = c.Location;
                    _resizeFlag = ResizeFlag.Move;
                }
                else if (pt.X > rc.X + rc.Width)
                {
                    _resizeFlag = ResizeFlag.Right;
                }
                else if (pt.Y > rc.Y + rc.Height)
                {
                    _resizeFlag = ResizeFlag.Bottom;
                }
                else if (pt.X < rc.X)
                {
                    _resizeFlag = ResizeFlag.Left;
                }
                else if (pt.Y < rc.Y)
                {
                    _resizeFlag = ResizeFlag.Top;
                }
            }
            Invalidate();
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _resizeFlag = ResizeFlag.None;
            }
            Invalidate();
        }

        private void angleViewMenuItem_Click(object sender, EventArgs e)
        {
            AngleView view = new AngleView();
            view.Location = new Point(100, 100);
            Controls.Add(view);
            Invalidate();
        }

        private void graphToolStripMenuItem_Click(object sender, EventArgs e)
        {
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

            PlotView plotView = new PlotView();
            plotView.Size = new Size(100, 100);
            plotView.Location = new Point(100, 100);
            plotView.Model = pM;
            Controls.Add(plotView);
            Invalidate();
        }

        private void tableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView dataGridView = new DataGridView();
            dataGridView.Size = new Size(100, 100);
            dataGridView.BackgroundColor = Color.FromArgb(64, 64, 64);
            dataGridView.Location = new Point(100, 100);
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.Columns.Add("Name", "Name");
            dataGridView.Columns.Add("Value", "Value");
            dataGridView.Columns.Add("Unit", "Unit");
            dataGridView.Columns["Unit"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Controls.Add(dataGridView);
            Invalidate();
        }
    }
}
