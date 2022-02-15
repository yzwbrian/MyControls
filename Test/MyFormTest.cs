using MyControls.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Test
{
    public partial class MyFormTest : MyForm
    {
        public MyFormTest()
        {
            InitializeComponent();
            _text = new TextBox()
            {
                Text = "TextBox",
                Size = new Size(150, 32),
                Location = new Point(0,0),
            };
            btna = new Button()
            {
                Text = "button",
                Location = new Point(0, 24),
            };

            panel = new Panel()
            {
                BorderStyle = BorderStyle.FixedSingle,
                Size = new Size(155, 80),
            };
            panel.Controls.Add(_text);
            panel.Controls.Add(btna);
            
        }

        private TextBox _text;
        private Button btna;
        private Panel panel;

        private MyDropDownForm mdf;
        
        private void btn1_Click(object sender, EventArgs e)
        {
            Point p = btn1.PointToScreen(new Point(0,25));
            if(mdf == null)
            {
                mdf = new MyDropDownForm(this, panel, p.X, p.Y);
                mdf.Size = panel.Size;
                mdf.Show(this);
            }
            else
            {
                if (!mdf.Visible)
                {
                    mdf.Location = p;
                    mdf.Show(this);
                }
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Point p = textBox1.PointToScreen(new Point(0, 25));
            if(mdf == null)
            {
                mdf = new MyDropDownForm(this, panel, p.X, p.Y);
                mdf.Size = panel.Size;
                mdf.Show(this);
                _text.Text = textBox1.Text;
            }
            else
            {
                if (!mdf.Visible)
                {
                    mdf.Location = p;
                    mdf.Show(this);
                }
                _text.Text = textBox1.Text;
            }
            
        }

        private MyForm mf = new MyForm() { Text = "FormTest", Visible = false };
        private void button1_Click(object sender, EventArgs e)
        {
            if (mf.IsDisposed)
            {
                mf = new MyForm() { Text = "FormTest", Visible = false };
            }
            mf.Visible = true;
        }
    }
}
