using MyControls.Manager;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MyControls.Controls
{
    #region class MyTabSelector
    public partial class MyTabSelector : Control
    {
        #region StringFormat
        protected StringFormat StringFormat { get; set; }
        #endregion

        #region IsHorizontal
        private bool _isHorizontal = true;
        public bool IsHorizontal {
            get { return _isHorizontal; }
            set
            {
                bool old = _isHorizontal;
                _isHorizontal = value;
                if (old != value)
                {
                    UpdateTabRects();
                    Invalidate();
                }
            } 
        }
        #endregion

        #region ItemSize
        private Size _itemSize = new Size(100, 24);
        public Size ItemSize
        {
            get { return _itemSize; }
            private set { _itemSize = value; }
        }
        #endregion

        #region ShowClose And CloseRect
        public bool ShowClose { get; set; }
        protected Rectangle CloseRect { get; set; }
        #endregion

        #region IconRect
        protected Rectangle IconRect { get; set; }
        #endregion

        #region ToolTip
        public MyToolTip ToolTip { get; set; }
        #endregion

        #region BaseTabControl
        private BaseTabControl _baseTabControl;
        public BaseTabControl BaseTabControl
        {
            get { return _baseTabControl; }
            set
            {
                _baseTabControl = value;
                if (_baseTabControl == null) return;

                _baseTabControl.SelectedIndexChanged += (sender, args) =>
                {
                    Invalidate();
                };
                _baseTabControl.ControlAdded += delegate
                {
                    Invalidate();
                    resize();
                    UpdateTabRects();
                };
                _baseTabControl.ControlRemoved += delegate
                {
                    Invalidate();
                    resize();
                    UpdateTabRects();
                };
                UpdateTabRects();
                resize();
                Invalidate();
            }
        }
        #endregion

        #region 构造函数
        public MyTabSelector()
        {
            SetStyle(ControlStyles.DoubleBuffer | ControlStyles.OptimizedDoubleBuffer, true);
            Cursor = Cursors.Default;

            //IsHorizontal = true;
            StringFormat = new StringFormat();
            StringFormat.Alignment = StringAlignment.Near;
            StringFormat.LineAlignment = StringAlignment.Center;
            StringFormat.Trimming |= StringTrimming.EllipsisCharacter;
            StringFormat.FormatFlags |= StringFormatFlags.LineLimit;

            _tabRects = new List<Rectangle>();
            ShowClose = true;
            CloseRect = new Rectangle(ItemSize.Width - 24, 8, 16, 16);
            IconRect = new Rectangle(4, 4, 24, 24);
        }

        #endregion

        #region _tabRects
        private List<Rectangle> _tabRects;
        #endregion

        #region UpdateTabRects()
        private void UpdateTabRects()
        {
            _tabRects.Clear();
            //If there isn't a base tab control, the rects shouldn't be calculated
            //If there aren't tab pages in the base tab control, the list should just be empty which has been set already; exit the void
            if (_baseTabControl == null || _baseTabControl.TabCount == 0) return;

            for (int i = 0; i < _baseTabControl.TabPages.Count; i++)
            {
                Rectangle rect;
                if (IsHorizontal)
                {
                    rect = new Rectangle(i * ItemSize.Width, 0, ItemSize.Width, ItemSize.Height);
                }
                else
                {
                    rect = new Rectangle(0, i * ItemSize.Height, ItemSize.Width, ItemSize.Height);
                }
                _tabRects.Add(rect);
            }
        }
        #endregion

        #region resize
        private void resize()
        {
            if (IsHorizontal)
                Width = Controls.Count * ItemSize.Width;
            else
                Height = Controls.Count * ItemSize.Height;
        }
        #endregion

        #region override mouse method
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            Invalidate();
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            Invalidate();
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            for (var i = 0; i < _tabRects.Count; i++)
            {
                if (_tabRects[i].Contains(e.Location))
                {
                    if (ShowClose)
                    {
                        Point p = PointToClient(MousePosition);
                        Rectangle rect;
                        if (IsHorizontal)
                            rect = new Rectangle(ItemSize.Width + _tabRects[i].X - CloseRect.Width, CloseRect.Y,
                                CloseRect.Width, CloseRect.Height);
                        else
                            rect = new Rectangle(ItemSize.Width - CloseRect.Width, _tabRects[i].Y, CloseRect.Width, CloseRect.Height);
                        if (rect.Contains(p))
                            break;
                    }

                    _baseTabControl.SelectedIndex = i;
                    break;
                }
            }

        }
        #endregion

        #region override OnPaint
        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.Clear(SkinManager.TabSelectorBackColor);
            if (_baseTabControl == null) return;

            Brush textBrush = new SolidBrush(SkinManager.TabSelectorForeColor);
            Brush overBrush = new SolidBrush(SkinManager.TabSelectorOverColor);
            Brush selectBrush = new SolidBrush(SkinManager.TabSelectorSelectColor);
            Brush selectLineBrush = new SolidBrush(SkinManager.TabSelectorSelectLineColor);
            Point p = PointToClient(MousePosition);
            //Draw tab headers
            for (int i = 0; i < _baseTabControl.TabCount; i++)
            {
                TabPage page = _baseTabControl.TabPages[i];
                if (i == _baseTabControl.SelectedIndex)
                {
                    g.FillRectangle(selectBrush, _tabRects[i]);
                    if (IsHorizontal)
                        g.FillRectangle(selectLineBrush, new Rectangle(_tabRects[i].X, 0, ItemSize.Width, 2));
                    else
                        g.FillRectangle(selectLineBrush, new Rectangle(0, _tabRects[i].Y, 2, ItemSize.Height));
                }
                else if (_tabRects[i].Contains(p))
                    g.FillRectangle(overBrush, _tabRects[i]);
                _drawIcon(i, g);
                _drawText(i, g, textBrush);
                _drawClose(_tabRects[i], g, p);
            }
            textBrush.Dispose();
            overBrush.Dispose();
            selectBrush.Dispose();
            selectLineBrush.Dispose();
        }
        #endregion

        #region _drawIcon
        private void _drawIcon(int index, Graphics g)
        {
            if (_baseTabControl.ImageList == null)
                return;

            String k = _baseTabControl.TabPages[index].ImageKey;
            Image img = _baseTabControl.ImageList.Images[k];

            if (k != null && img != null)
            {
                if (IsHorizontal)
                    g.DrawImageUnscaled(_baseTabControl.ImageList.Images[k], _tabRects[index].X + IconRect.X, IconRect.Y, IconRect.Width, IconRect.Height);
                else
                    g.DrawImageUnscaled(_baseTabControl.ImageList.Images[k], IconRect.X, _tabRects[index].Y + IconRect.Y, IconRect.Width, IconRect.Height);
            }

        }
        #endregion

        #region _drawText
        private void _drawText(int index, Graphics g, Brush textBrush)
        {
            String text = _baseTabControl.TabPages[index].Text;
            if (text != null)
            {
                if (IsHorizontal)
                {
                    g.DrawString(text, Font, textBrush,
                    new Rectangle(_tabRects[index].X + IconRect.Width, 0, ItemSize.Width - IconRect.Width - CloseRect.Width,
                    ItemSize.Height), StringFormat);
                }
                else
                {
                    g.DrawString(text, Font, textBrush,
                    new Rectangle(IconRect.Width, _tabRects[index].Y, ItemSize.Width - IconRect.Width - CloseRect.Width,
                    ItemSize.Height), StringFormat);
                }
            }
        }
        #endregion

        #region _drawClose
        private void _drawClose(Rectangle tabRect, Graphics g, Point p)
        {
            if (ShowClose)
            {
                Rectangle rect;
                if (IsHorizontal)
                    rect = new Rectangle(ItemSize.Width + tabRect.X - CloseRect.Width, CloseRect.Y,
                        CloseRect.Width, CloseRect.Height);
                else
                    rect = new Rectangle(ItemSize.Width - CloseRect.Width, tabRect.Y + CloseRect.Y,
                        CloseRect.Width, CloseRect.Height);

                if (rect.Contains(p))
                    g.DrawImageUnscaled(Res.close_red_10, rect);
                else
                    g.DrawImageUnscaled(Res.close_10, rect);
            }
        }
        #endregion
    }
    #endregion

    #region class TabControl
    public class BaseTabControl : TabControl
    {
        public BaseTabControl() : base()
        {
            Multiline = true;
            Cursor = Cursors.Default;
        }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x1328 && !DesignMode) m.Result = (IntPtr)1;
            else base.WndProc(ref m);
        }
    }
    #endregion
}
