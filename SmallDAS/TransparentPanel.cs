﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmallDAS
{
    class TransparentPanel : Panel
    {
        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x00000020; // WS_EX_TRANSPARENT

                return cp;
            }
        }

        protected override void OnPaint(PaintEventArgs e) =>
            e.Graphics.FillRectangle(new SolidBrush(this.BackColor), this.ClientRectangle);
    }
}
