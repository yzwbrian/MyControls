using MyControls;
using MyControls.Controls;
using MyControls.Forms;
using System;
using System.Drawing;

namespace Test
{
    public partial class MyToolTipTest : MyForm
    {
        public MyToolTipTest()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyToolTip tip = new MyToolTip()
            {
                Icon = Res.logo_16,
                Title = "tooltipTitle",
                Content = BackColor.R + ", " + BackColor.G + ", " + BackColor.A,
            };
            tip.Show(".", button1, 0,30,3000);
            
        }
    }
}
