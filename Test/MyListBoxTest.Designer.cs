
namespace Test
{
    partial class MyListBoxTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Drawing.StringFormat stringFormat1 = new System.Drawing.StringFormat();
            this.myListBox1 = new MyControls.Controls.MyListBox();
            this.SuspendLayout();
            // 
            // myListBox1
            // 
            this.myListBox1.BackColor = System.Drawing.Color.White;
            this.myListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myListBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.myListBox1.ForeColor = System.Drawing.Color.Black;
            this.myListBox1.FormattingEnabled = true;
            this.myListBox1.ItemHeight = 32;
            this.myListBox1.Location = new System.Drawing.Point(0, 0);
            this.myListBox1.Name = "myListBox1";
            this.myListBox1.Size = new System.Drawing.Size(273, 222);
            stringFormat1.Alignment = System.Drawing.StringAlignment.Near;
            stringFormat1.FormatFlags = System.Drawing.StringFormatFlags.LineLimit;
            stringFormat1.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None;
            stringFormat1.LineAlignment = System.Drawing.StringAlignment.Center;
            stringFormat1.Trimming = System.Drawing.StringTrimming.EllipsisCharacter;
            this.myListBox1.StringFormat = stringFormat1;
            this.myListBox1.TabIndex = 0;
            // 
            // MyListBoxTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 222);
            this.Controls.Add(this.myListBox1);
            this.Name = "MyListBoxTest";
            this.Text = "MyListBoxTest";
            this.Load += new System.EventHandler(this.MyListBoxTest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MyControls.Controls.MyListBox myListBox1;
    }
}