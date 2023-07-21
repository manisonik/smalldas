using MathNet.Numerics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SmallDAS
{
    public class UserToolStripRenderer : ToolStripProfessionalRenderer
    {
        public UserToolStripRenderer(ProfessionalColorTable professionalColorTable) : base(professionalColorTable) { }

        /*protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            if (e.Item.IsOnDropDown)
            {
                Size size = e.Item.Size;
                size.Width = e.Item.Width;
                size.Height = e.Item.Height;

                Rectangle rectangle = new Rectangle(Point.Empty, size);

                Brush brush = new SolidBrush(Color.Red);
                e.Graphics.FillRectangle(brush, rectangle);

                //e.Graphics.DrawRectangle(pen, rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
            }
        }*/
    }
}
