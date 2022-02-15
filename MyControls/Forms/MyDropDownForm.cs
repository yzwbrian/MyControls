
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyControls.Forms
{
    public partial class MyDropDownForm: Form,IMessageFilter
    {
        #region private 变量
        private bool _hasFocus = true;
        private Control _parent;
        private Control _child;
        #endregion

        #region property
        public bool HasFocus { get { return _hasFocus; } }
        public Control ParentControl { get { return _parent; } }
        public Control ChildControl { get { return _child; } }
        #endregion

        #region 构造函数
        private MyDropDownForm(){
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(24, 24);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MyDropDownForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "MyDropDownForm";
            TopMost = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parent">父控件</param>
        /// <param name="child">子控件</param>
        /// <param name="x">窗体x坐标</param>
        /// <param name="y">窗体y坐标</param>
        /// <param name="hasFocus">窗体是否有焦点</param>
        public MyDropDownForm(Control parent, Control child, int x, int y, bool hasFocus = false) 
            : this()
        {
            _parent = parent;
            _hasFocus = hasFocus;
            Left = x;
            Top = y;
            if (child != null)
            {
                _child = child;
                Controls.Add(child);
            }

            if (parent != null)
            {
                Form pf = parent.FindForm();
                if (pf != null && !pf.IsDisposed)
                {
                    pf.LocationChanged += (o, e) => { Hide(); };
                }
            }
        }

        public MyDropDownForm(Control parent, int x, int y, int width, int height, bool hasFocus = false) 
            : this(parent, null, x, y, hasFocus)
        {
            Width = width;
            Height = height;
        }

        #endregion

        #region override events
        /// <summary>
        /// Handles the LocationChanged event of the frmP control.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        protected override void OnLocationChanged(EventArgs e)
        {
            base.OnLocationChanged(e);
            Hide();
        }
        /// <summary>
        /// Handles the HandleDestroyed event of the FrmDownBoard control.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        protected override void OnHandleDestroyed(EventArgs e)
        {
            base.OnHandleDestroyed(e);
            Application.RemoveMessageFilter(this);
        }
        /// <summary>
        /// Handles the HandleCreated event of the FrmDownBoard control.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            Application.AddMessageFilter(this);
        }
        #endregion

        #region 无焦点窗体

        /// <summary>
        /// Sets the active window.
        /// </summary>
        /// <param name="handle">The handle.</param>
        /// <returns>IntPtr.</returns>
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private extern static IntPtr SetActiveWindow(IntPtr handle);
        /// <summary>
        /// The wm activate
        /// </summary>
        private const int WM_ACTIVATE = 0x006;
        /// <summary>
        /// The wm activateapp
        /// </summary>
        private const int WM_ACTIVATEAPP = 0x01C;
        /// <summary>
        /// The wm ncactivate
        /// </summary>
        private const int WM_NCACTIVATE = 0x086;
        /// <summary>
        /// The wa inactive
        /// </summary>
        private const int WA_INACTIVE = 0;
        /// <summary>
        /// The wm mouseactivate
        /// </summary>
        private const int WM_MOUSEACTIVATE = 0x21;
        /// <summary>
        /// The ma noactivate4
        /// </summary>
        private const int MA_NOACTIVATE = 3;
        /// <summary>
        /// WNDs the proc.
        /// </summary>
        /// <param name="m">要处理的 Windows <see cref="T:System.Windows.Forms.Message" />。</param>
        protected override void WndProc(ref Message m)
        {
            if (!_hasFocus)
            {
                if (m.Msg == WM_MOUSEACTIVATE)
                {
                    m.Result = new IntPtr(MA_NOACTIVATE);
                    return;
                }
                else if (m.Msg == WM_NCACTIVATE)
                {
                    if (((int)m.WParam & 0xFFFF) != WA_INACTIVE)
                    {
                        if (m.LParam != IntPtr.Zero)
                        {
                            SetActiveWindow(m.LParam);
                        }
                        else
                        {
                            SetActiveWindow(IntPtr.Zero);
                        }
                    }
                }
            }
            base.WndProc(ref m);
        }

        #endregion

        #region PreFilterMessage
        /// 在调度消息之前将其筛选出来。
        /// </summary>
        /// <param name="m">要调度的消息。无法修改此消息。</param>
        /// <returns>如果筛选消息并禁止消息被调度，则为 true；如果允许消息继续到达下一个筛选器或控件，则为 false。</returns>
        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg != 0x0201 || this.Visible == false)
                return false;
            var pt = this.PointToClient(MousePosition);
            this.Visible = this.ClientRectangle.Contains(pt);
            return false;
        }
        #endregion
    }
}
