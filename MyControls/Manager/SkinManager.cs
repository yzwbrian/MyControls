
using System.Drawing;

namespace MyControls.Manager
{
    public class SkinManager
    {
        public static Color FormBorderColor { get { return Color.Red; } }
        public static Color FormBackColor { get { return Color.White; } }
        public static Color FormCaptionBackColor { get { return ControlBackColor; } }
        public static Color FormCaptionForeColor { get { return ControlForeColor; } }
        public static Color FormButtonHoveColor { get { return Color.FromArgb(200, 200, 200); } }
        public static Color FormButtonDownColor { get { return Color.FromArgb(160, 160, 160); } }
        public static Color SelectColor { get { return Color.FromArgb(224, 224, 255); } }
        public static Color SelectLineColor { get { return Color.FromArgb(0, 102, 204); } }
        public static Color ControlBackColor { get { return Color.FromArgb(240, 240, 255); } }
        public static Color ControlForeColor { get { return Color.Black; } }
        public static Color TooltipBackColor { get { return Color.White; } }
        public static Color TooltipForeColor { get { return ControlForeColor; } }
        public static Color TooltipBorderColor { get { return SelectLineColor; } }
        public static Color ListItemBackColor { get { return Color.White; } }
        public static Color ListItemSelectBackColor { get { return SelectColor; } }
        public static Color ListItemSelectLineColor { get { return SelectLineColor; } }


        public static Font ControlFont { get { return new Font("Microsoft YaHei UI", 9, FontStyle.Regular); } }
        public static Font TileFont { get { return new Font("Microsoft YaHei UI", 9, FontStyle.Bold); } }
        public static Font TextFont { get { return ControlFont; } }
    }
}

