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
    public partial class MainForm : MyForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if(sender == btnButtonTest)
            {
                new MyButtonTest().Show(this);
            }else if(sender == btnFormTest)
            {
                new MyFormTest().Show(this);
            }else if(sender == btnListBoxTest)
            {
                new MyListBoxTest().Show(this);
            }else if(sender == btnComboBoxTest)
            {
                new MyComboBoxTest().Show(this);
            }else if(sender == btnToolTipTest)
            {
                new MyToolTipTest().Show(this);
            }else if(sender == btnTabControlTest)
            {
                new MyTabControlTest().Show(this);
            }
        }
    }
}
