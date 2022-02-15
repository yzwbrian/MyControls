using MyControls.Manager;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyControls.Controls
{
    public partial class MyButton: Button
    {
        public bool ShowClose { get; set; }
        public Rectangle CloseRect { get; set; }
        public MyButton(): base()
        {
            Font = SkinManager.ControlFont;
            BackColor = SkinManager.ControlBackColor;
            ForeColor = SkinManager.ControlForeColor;

            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            FlatAppearance.MouseOverBackColor = SkinManager.ControlOverColor;
            FlatAppearance.MouseDownBackColor = SkinManager.ControlDownColor;

            ImageAlign = ContentAlignment.TopLeft;
            TextAlign = ContentAlignment.TopCenter;
            TextImageRelation = TextImageRelation.ImageBeforeText;
            Size = new Size(120, 24);
        }

        protected override void OnMouseMove(MouseEventArgs mevent)
        {
            base.OnMouseMove(mevent);
            if (ShowClose)
            {
                Invalidate(CloseRect);
            }
                
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            if(ShowClose)
                Invalidate(CloseRect);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            CloseRect = new Rectangle(Width - 16, (Height - 16) / 2, 16, 16);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (ShowClose)
            {
                Point p = PointToClient(MousePosition);
                if (CloseRect.Contains(p))
                    e.Graphics.DrawImageUnscaled(Res.w_close_red_16, CloseRect);
                else
                    e.Graphics.DrawImageUnscaled(Res.w_close_16, CloseRect);
            }
        }
    }
}
