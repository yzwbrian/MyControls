using MyControls;
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
    public partial class MyTabControlTest : MyForm
    {
        public MyTabControlTest()
        {
            InitializeComponent();
        }

        private void MyTabControlTest_Load(object sender, EventArgs e)
        {
            imageList1.Images.Add("t1", Res.logo_16);
            imageList1.Images.Add("t2", Res.doc_16);
            tabPage1.ImageKey = "t1";
            tabPage2.ImageKey = "t2";
            baseTabControl1.ImageList = imageList1;
        }

        private const int left = 2, top = 26, right = 2, bottom = 35;
        private void btnTop_Click(object sender, EventArgs e)
        {
            myTabSelector1.IsHorizontal = true;
            myTabSelector1.Bounds = new Rectangle(left, top, Width - left - right, 24);
            myTabSelector1.Invalidate();
            baseTabControl1.Bounds = new Rectangle(left,top+24, Width -left -right, 
                Height-top - 24 -bottom);
            
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            myTabSelector1.IsHorizontal = false;
            myTabSelector1.Bounds = new Rectangle(left, top, 100, Height - top -bottom);
            myTabSelector1.Invalidate();
            baseTabControl1.Bounds = new Rectangle(2 + 100, top, Width - left - right - 100, Height - top - bottom);
        }

        private void btnBottom_Click(object sender, EventArgs e)
        {

        }

        private void btnRight_Click(object sender, EventArgs e)
        {

        }
    }
}
