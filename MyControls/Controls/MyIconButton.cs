using MyControls.Common;
using MyControls.Manager;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using SizeType = MyControls.Common.SizeType;

namespace MyControls.Controls
{

    public class MyIconButton : Button
    {
        #region 属性
        public new Image Image { get; private set; }
        public new Image BackgroundImage { get; private set; }

        public Image Icon {
            get { return base.BackgroundImage; }
            set { base.BackgroundImage = value; }
        }
        public new Size Size { 
            get { return base.Size; }
            private set { base.Size = value; } 
        }
        private SizeType _sizeType;
        public SizeType SizeType
        {
            get { return _sizeType; }
            set { 
                _sizeType = value;
                Size = new Size((int)value, (int)value);
            }
        }
        public new string Text {
            get;private set;
        }
        private bool _isRound;
        public bool IsRound
        {
            get { return _isRound; }
            set {
                bool old = _isRound;
                _isRound = value;
                if (old != value)
                    Invalidate();
            }
        }
        #endregion

        #region 构造函数
        public MyIconButton(): base()
        {
            Font = SkinManager.ControlFont;
            BackColor = SkinManager.ControlBackColor;
            ForeColor = SkinManager.ControlForeColor;

            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            FlatAppearance.MouseOverBackColor = SkinManager.ControlOverColor;
            FlatAppearance.MouseDownBackColor = SkinManager.ControlDownColor;

            SizeType = SizeType.M;
            BackgroundImageLayout = ImageLayout.Center;
            
            base.Text = null;
            IsRound = true;
            Icon = Res.logo_16;
        }
        #endregion

        #region override method
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (IsRound)
            {
                GraphicsPath gp = new GraphicsPath();
                gp.AddEllipse(ClientRectangle);
                Region = new Region(gp);
            }
        }
        #endregion
    }
}
