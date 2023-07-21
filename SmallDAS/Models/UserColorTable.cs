using System.Drawing;
using System.Windows.Forms;

namespace SmallDAS
{
    public class UserColorTable : ProfessionalColorTable
    {
        public override Color ImageMarginGradientBegin
        {
            get { return Color.FromArgb(38, 38, 38); }
        }

        public override Color ImageMarginGradientMiddle
        {
            get { return Color.FromArgb(38, 38, 38); }
        }

        public override Color ImageMarginGradientEnd
        {
            get { return Color.FromArgb(38, 38, 38); }
        }

        public override Color MenuItemSelected
        {
            get { return Color.FromArgb(64, 64, 64); }
        }

        public override Color MenuBorder  //added for changing the menu border
        {
            get { return Color.FromArgb(64, 64, 64); }
        }
        public override Color MenuStripGradientBegin
        {
            get { return Color.FromArgb(38, 38, 38); }
        }

        public override Color MenuStripGradientEnd
        {
            get { return Color.FromArgb(38, 38, 38); }
        }

        public override Color MenuItemBorder
        {
            //get { return Color.Red; }
            get { return Color.FromArgb(128, 128, 128); }
        }

        public override Color MenuItemSelectedGradientBegin
        {
            get { return Color.FromArgb(64, 64, 64); }
        }

        public override Color MenuItemSelectedGradientEnd
        {
            get { return Color.FromArgb(64, 64, 64); }
        }

        public override Color MenuItemPressedGradientBegin
        {
            get { return Color.FromArgb(38, 38, 38); }
        }

        public override Color MenuItemPressedGradientMiddle
        {
            get { return Color.FromArgb(38, 38, 38); }
        }

        public override Color MenuItemPressedGradientEnd
        {
            get { return Color.FromArgb(38, 38, 38); }
        }

        public override Color ToolStripBorder
        {
            get { return Color.Red; }
        }

        public override Color ToolStripDropDownBackground
        {
            get { return Color.FromArgb(38, 38, 38); }
        }
    }
}
