using MyControls;
using MyControls.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Test
{
    public partial class MyListBoxTest : Form
    {
        public MyListBoxTest()
        {
            InitializeComponent();
        }

        private void MyListBoxTest_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < 10; i++)
            {
                MyListItem item = new MyListItem()
                {
                    Icon = Res.logo_16,
                    Title = i + "__ListItemTestTitle",
                    Text = i + "__ListItemContentTestI__ListItemContentTestI__ListItemContentTestI",
                };
                myListBox1.Items.Add(item);
            }
        }
    }
}
