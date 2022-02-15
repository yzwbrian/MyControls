using MyControls;
using MyControls.Controls;
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
    public partial class MyButtonTest : MyForm
    {
        public MyButtonTest()
        {
            InitializeComponent();
        }

        private void MyButtonTest_Load(object sender, EventArgs e)
        {
            MyIconButton ib = new MyIconButton()
            {
                Location = new Point(300, 32)
            };
            Controls.Add(ib);

            myButton2.Image = Res.logo_16;
            
        }
    }
}
