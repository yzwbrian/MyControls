
using MyControls.Manager;
using System.Drawing;
using System.Windows.Forms;

namespace MyControls.Controls
{
    public partial class MyToolTip:  ToolTip
    {
        #region 属性
        public new ToolTipIcon ToolTipIcon { get; private set; }
        public Image Icon { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public Size ShowSize { get; set; }
        #endregion

        public const int DW = 120;
        public const int DH = 32;

        private Rectangle _iconRect = new Rectangle(2, 2, 16, 16);

        #region 构造函数
        public MyToolTip(): base()
        {
            OwnerDraw = true;
            IsBalloon = false;
            ShowSize = new Size(DW, DH);

            Popup += MyToolTip_Popup;
            Draw += MyToolTip_Draw;
        }

        #endregion

        #region 事件
        private void MyToolTip_Draw(object sender, DrawToolTipEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle b = e.Bounds;
            //background
            using(var bgBrush = new SolidBrush(SkinManager.TooltipBackColor))
            {
                g.FillRectangle(bgBrush, b);
                bgBrush.Dispose();
            }
            //border
            using(var borderPen = new Pen(SkinManager.TooltipBorderColor))
            {
                g.DrawRectangle(borderPen, b.X, b.Y, b.Width -1, b.Height -1);
                borderPen.Dispose();
            }
            //icon
            if(Icon != null)
            {
                g.DrawImage(Icon, _iconRect);
            }

            Brush textBrush = new SolidBrush(SkinManager.TooltipForeColor);
            //title
            if(Title != null)
            {
                int l = Icon == null ? _iconRect.X : _iconRect.Width+2;
                g.DrawString(Title, SkinManager.TileFont, textBrush, new Rectangle(
                    l, _iconRect.Y, b.Width - l, b.Height/2));
            }
            //content
            if(Content != null)
            {
                g.DrawString(Content, SkinManager.TextFont, textBrush, new Rectangle(
                    _iconRect.X, b.Height/2, b.Width - _iconRect.X, b.Height/2));
            }
            textBrush.Dispose();
        }

        private void MyToolTip_Popup(object sender, PopupEventArgs e)
        {
            e.ToolTipSize = ShowSize;
        }
        #endregion
    }
}
