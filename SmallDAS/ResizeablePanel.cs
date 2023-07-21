using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SmallDAS
{
    public class ResizeablePanel : ContainerControl
    {
        enum ResizeFlag
        {
            None = 0,
            Right = 1,
            Bottom = 2,
            Left = 3,
            Top = 4,
        }

        private ResizeFlag resizeFlag = ResizeFlag.None;
        private bool _selected;

        public ResizeablePanel()
        {
            DoubleBuffered = true;
            Padding = new Padding(5, 5, 5, 5);
            Size = new Size(500, 500);
            Location = new Point(0, 0);
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            e.Control.Dock = DockStyle.Fill;
            e.Control.MouseClick += delegate
            {
                _selected = true;
                Invalidate(true);
            };
            base.OnControlAdded(e);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.ControlKey | Keys.Control))
            {
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Control)
            {
                Debug.WriteLine("Control key down");
            }
            
            base.OnKeyDown(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            int w = Width;
            int h = Height;

            if (e.Button == MouseButtons.Left)
            {
                if (e.X > w - 4)
                {
                    resizeFlag = ResizeFlag.Right;
                }
                else if (e.Y > h - 4)
                {
                    resizeFlag = ResizeFlag.Bottom;
                }
                else if (e.X < 4)
                {
                    resizeFlag = ResizeFlag.Left;
                }
                else if (e.Y < 4)
                {
                    resizeFlag = ResizeFlag.Top;
                }

                Invalidate();
            }

            base.OnMouseDown(e);
        }

        private void DrawCursor(MouseEventArgs e)
        {
            int w = Width;
            int h = Height;

            if (e.X > w - 4)
            {
                Cursor = Cursors.SizeWE;
            }
            else if (e.Y > h - 4)
            {
                Cursor = Cursors.SizeNS;
            }
            else if (e.X < 4)
            {
                Cursor = Cursors.SizeWE;
            }
            else if (e.Y < 4)
            {
                Cursor = Cursors.SizeNS;
            }
            else
            {
                Cursor = Cursors.Default;
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            Point pt = Cursor.Position;
            Point cpt = Parent.PointToClient(pt);

            DrawCursor(e);

            switch (resizeFlag)
            {
                case ResizeFlag.Right:
                    {
                        int h = Size.Height;
                        this.Size = new Size(e.X, h);
                        Invalidate(true);
                    }
                    break;
                case ResizeFlag.Bottom:
                    {
                        int w = Size.Width;
                        this.Size = new Size(w, e.Y);
                        Invalidate(true);
                    }
                    break;
                case ResizeFlag.Left:
                    {
                        int h = Size.Height;
                        int r = Location.X + Size.Width;
                        Location = new Point(cpt.X, Location.Y);
                        Size = new Size(r - cpt.X, h);
                        Invalidate(true);
                    }
                    break;
                case ResizeFlag.Top:
                    {
                        int w = Size.Width;
                        int b = Location.Y + Size.Height;
                        Location = new Point(Location.X, cpt.Y);
                        Size = new Size(w, b - cpt.Y);
                        Invalidate(true);
                    }
                    break;
            }

            base.OnMouseMove(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                resizeFlag = ResizeFlag.None;
            }

            Invalidate();
            base.OnMouseUp(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            var cr = ClientRectangle;

            if (resizeFlag != ResizeFlag.None)
            {
                using (Pen pen = new Pen(Color.CadetBlue, 2))
                {
                    pen.DashStyle = DashStyle.Solid;
                    g.DrawRectangle(pen, cr);
                }
            }
            else if (_selected)
            {
                int size = 6;
                using (Pen pen = new Pen(Color.CadetBlue, 2))
                {
                    pen.DashStyle = DashStyle.Dash;
                    Rectangle rc = new Rectangle(0, 0, cr.Width, cr.Height);
                    g.DrawRectangle(pen, rc);
                }
            }
            base.OnPaint(e);
        }
    }
}
