
namespace Test
{
    partial class MyButtonTest
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
            this.myButton1 = new MyControls.Controls.MyButton();
            this.myButton2 = new MyControls.Controls.MyButton();
            this.SuspendLayout();
            // 
            // myButton1
            // 
            this.myButton1.BackColor = System.Drawing.Color.White;
            this.myButton1.CloseRect = new System.Drawing.Rectangle(104, 4, 16, 16);
            this.myButton1.FlatAppearance.BorderSize = 0;
            this.myButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.myButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.myButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myButton1.ForeColor = System.Drawing.Color.Black;
            this.myButton1.Location = new System.Drawing.Point(12, 36);
            this.myButton1.Name = "myButton1";
            this.myButton1.ShowClose = false;
            this.myButton1.Size = new System.Drawing.Size(120, 24);
            this.myButton1.TabIndex = 0;
            this.myButton1.Text = "myButton1";
            this.myButton1.UseVisualStyleBackColor = false;
            // 
            // myButton2
            // 
            this.myButton2.BackColor = System.Drawing.Color.White;
            this.myButton2.CloseRect = new System.Drawing.Rectangle(104, 4, 16, 16);
            this.myButton2.FlatAppearance.BorderSize = 0;
            this.myButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.myButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.myButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myButton2.ForeColor = System.Drawing.Color.Black;
            this.myButton2.Location = new System.Drawing.Point(138, 36);
            this.myButton2.Name = "myButton2";
            this.myButton2.ShowClose = true;
            this.myButton2.Size = new System.Drawing.Size(120, 24);
            this.myButton2.TabIndex = 0;
            this.myButton2.Text = "myButton1";
            this.myButton2.UseVisualStyleBackColor = false;
            // 
            // MyButtonTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 86);
            this.Controls.Add(this.myButton2);
            this.Controls.Add(this.myButton1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "MyButtonTest";
            this.Text = "MyButtonTest";
            this.Load += new System.EventHandler(this.MyButtonTest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MyControls.Controls.MyButton myButton1;
        private MyControls.Controls.MyButton myButton2;
    }
}