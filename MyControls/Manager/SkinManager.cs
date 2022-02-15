
using System.Drawing;

namespace MyControls.Manager
{
    public class SkinManager
    {
        public static Color ControlBackColor { get { return Color.White; } }
        public static Color ControlForeColor { get { return Color.Black; } }

        public static Color ControlOverColor { get { return Color.FromArgb(220, 220, 220); } }
        public static Color ControlDownColor { get { return Color.FromArgb(190, 190, 190); } }

        public static Color FormBorderColor { get { return Color.Red; } }
        public static Color FormCaptionBackColor { get { return Color.FromArgb(220,220,220); } }
        public static Color FormCaptionForeColor { get { return ControlForeColor; } }
        public static Color FormButtonOverColor { get { return Color.FromArgb(200, 200, 200); } }
        public static Color FormButtonDownColor { get { return Color.FromArgb(160, 160, 160); } }
        public static Color FormCloseButtonOverColor { get { return Color.FromArgb(240, 190, 230); } }
        public static Color FormCloseButtonDownColor { get { return Color.FromArgb(240, 160, 230); } }
        
        public static Color SelectColor { get { return Color.FromArgb(224, 224, 255); } }
        public static Color SelectLineColor { get { return Color.FromArgb(0, 102, 204); } }

        public static Color TooltipBackColor { get { return Color.White; } }
        public static Color TooltipForeColor { get { return ControlForeColor; } }
        public static Color TooltipBorderColor { get { return SelectLineColor; } }

        public static Color ListItemBackColor { get { return Color.White; } }
        public static Color ListItemSelectBackColor { get { return SelectColor; } }
        public static Color ListItemSelectLineColor { get { return SelectLineColor; } }

        public static Color TabSelectorBackColor { get { return FormCaptionBackColor; } }
        public static Color TabSelectorForeColor { get { return ControlForeColor; } }
        public static Color TabSelectorOverColor { get { return FormButtonOverColor; } }
        public static Color TabSelectorSelectColor { get { return Color.White; } }
        public static Color TabSelectorSelectLineColor { get { return SelectLineColor; } }

        public static Font ControlFont { get { return new Font("Microsoft YaHei UI", 9, FontStyle.Regular); } }
        public static Font TileFont { get { return new Font("Microsoft YaHei UI", 9, FontStyle.Bold); } }
        public static Font TextFont { get { return ControlFont; } }

        
    }
}

