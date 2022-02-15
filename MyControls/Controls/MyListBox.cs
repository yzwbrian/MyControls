
using MyControls.Manager;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyControls.Controls
{
    public partial class MyListBox: ListBox
    {
        #region 属性
        public StringFormat StringFormat { get; set; }
        protected Rectangle IconRect { get; set; }
        protected Rectangle TitleRect { get; set; }
        protected Rectangle TextRect { get; set; }
        #endregion

        #region 构造函数
        public MyListBox() : base()
        {
            SetStyle(ControlStyles.DoubleBuffer | ControlStyles.OptimizedDoubleBuffer, true);
            DrawMode = DrawMode.OwnerDrawFixed;
            ItemHeight = 32;
            HorizontalScrollbar = false;

            BackColor = SkinManager.ControlBackColor;
            ForeColor = SkinManager.ControlForeColor;

            StringFormat = new StringFormat();
            StringFormat.Alignment = StringAlignment.Near;
            StringFormat.LineAlignment = StringAlignment.Center;
            StringFormat.Trimming |= StringTrimming.EllipsisCharacter;
            StringFormat.FormatFlags |= StringFormatFlags.LineLimit;

            IconRect = new Rectangle(4, 2, 16, 16);
            TitleRect = new Rectangle(24, 2, 24, 16);
            TextRect = new Rectangle(4, 17, 4, 16);

        }
        #endregion

        #region override SizeChanged
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            Invalidate();
        }
        #endregion

        #region override OnDrawItem
        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (Items.Count == 0)
                return;
            Type t = Items[e.Index].GetType();
            MyListItem item = t.IsSubclassOf(typeof(MyListItem)) || t == typeof(MyListItem) ?
                (MyListItem)Items[e.Index] : null;
            //绘制背景
            Brush bgBrush = new SolidBrush(SkinManager.ListItemBackColor);
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                bgBrush = new SolidBrush(SkinManager.ListItemSelectBackColor);
                e.Graphics.FillRectangle(bgBrush, e.Bounds);

                //绘制焦点框
                var sb = new SolidBrush(SkinManager.ListItemSelectLineColor);
                e.Graphics.FillRectangle(sb, 0, e.Bounds.Y, 2, e.Bounds.Height);
                sb.Dispose();
            }
            else
                e.Graphics.FillRectangle(bgBrush, e.Bounds);
            bgBrush.Dispose();


            //绘制图标
            if (item != null && item.Icon != null)
            {
                e.Graphics.DrawImageUnscaled(item.Icon, IconRect.X, e.Bounds.Y + IconRect.Y,
                    IconRect.Width, IconRect.Height);
            }

            Brush textBrush = new SolidBrush(SkinManager.ControlForeColor);
            //绘制标题文本
            Rectangle textRect = new Rectangle(TitleRect.X, TitleRect.Y + e.Bounds.Y,
                e.Bounds.Width - TitleRect.Width, TitleRect.Height);
            e.Graphics.DrawString(item == null ? GetItemText(Items[e.Index]) : item.Title,
                SkinManager.TileFont, textBrush,
                textRect, StringFormat);

            //绘制内容文本
            textRect = new Rectangle(TextRect.X, TextRect.Y + e.Bounds.Y,
                e.Bounds.Width - TextRect.Width, textRect.Height);
            e.Graphics.DrawString(item == null ? GetItemText(Items[e.Index]) : item.Text,
                SkinManager.TextFont, textBrush,
                textRect, StringFormat);
            textBrush.Dispose();
        }
        #endregion
    }

    #region class MyListItem
    public class MyListItem
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public Image Icon { get; set; }

    }
    #endregion
}
