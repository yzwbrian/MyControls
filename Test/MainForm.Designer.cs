
namespace Test
{
    partial class MainForm
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
            this.btnButtonTest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFormTest = new System.Windows.Forms.Button();
            this.btnListBoxTest = new System.Windows.Forms.Button();
            this.btnTabControlTest = new System.Windows.Forms.Button();
            this.btnComboBoxTest = new System.Windows.Forms.Button();
            this.btnToolTipTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnButtonTest
            // 
            this.btnButtonTest.Location = new System.Drawing.Point(12, 57);
            this.btnButtonTest.Name = "btnButtonTest";
            this.btnButtonTest.Size = new System.Drawing.Size(110, 23);
            this.btnButtonTest.TabIndex = 0;
            this.btnButtonTest.Text = "按钮(Button)";
            this.btnButtonTest.UseVisualStyleBackColor = true;
            this.btnButtonTest.Click += new System.EventHandler(this.button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "自定义控件测试例子：";
            // 
            // btnFormTest
            // 
            this.btnFormTest.Location = new System.Drawing.Point(128, 57);
            this.btnFormTest.Name = "btnFormTest";
            this.btnFormTest.Size = new System.Drawing.Size(129, 23);
            this.btnFormTest.TabIndex = 1;
            this.btnFormTest.Text = "窗体(Form)";
            this.btnFormTest.UseVisualStyleBackColor = true;
            this.btnFormTest.Click += new System.EventHandler(this.button_Click);
            // 
            // btnListBoxTest
            // 
            this.btnListBoxTest.Location = new System.Drawing.Point(12, 86);
            this.btnListBoxTest.Name = "btnListBoxTest";
            this.btnListBoxTest.Size = new System.Drawing.Size(110, 23);
            this.btnListBoxTest.TabIndex = 2;
            this.btnListBoxTest.Text = "列表框(ListBox)";
            this.btnListBoxTest.UseVisualStyleBackColor = true;
            this.btnListBoxTest.Click += new System.EventHandler(this.button_Click);
            // 
            // btnTabControlTest
            // 
            this.btnTabControlTest.Location = new System.Drawing.Point(128, 115);
            this.btnTabControlTest.Name = "btnTabControlTest";
            this.btnTabControlTest.Size = new System.Drawing.Size(129, 23);
            this.btnTabControlTest.TabIndex = 5;
            this.btnTabControlTest.Text = "选项页(TabControl)";
            this.btnTabControlTest.UseVisualStyleBackColor = true;
            this.btnTabControlTest.Click += new System.EventHandler(this.button_Click);
            // 
            // btnComboBoxTest
            // 
            this.btnComboBoxTest.Location = new System.Drawing.Point(128, 86);
            this.btnComboBoxTest.Name = "btnComboBoxTest";
            this.btnComboBoxTest.Size = new System.Drawing.Size(129, 23);
            this.btnComboBoxTest.TabIndex = 3;
            this.btnComboBoxTest.Text = "下拉框(ComboBox)";
            this.btnComboBoxTest.UseVisualStyleBackColor = true;
            this.btnComboBoxTest.Click += new System.EventHandler(this.button_Click);
            // 
            // btnToolTipTest
            // 
            this.btnToolTipTest.Location = new System.Drawing.Point(11, 115);
            this.btnToolTipTest.Name = "btnToolTipTest";
            this.btnToolTipTest.Size = new System.Drawing.Size(111, 23);
            this.btnToolTipTest.TabIndex = 4;
            this.btnToolTipTest.Text = "提示框(ToolTip)";
            this.btnToolTipTest.UseVisualStyleBackColor = true;
            this.btnToolTipTest.Click += new System.EventHandler(this.button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 158);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnToolTipTest);
            this.Controls.Add(this.btnComboBoxTest);
            this.Controls.Add(this.btnTabControlTest);
            this.Controls.Add(this.btnListBoxTest);
            this.Controls.Add(this.btnFormTest);
            this.Controls.Add(this.btnButtonTest);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximumSize = new System.Drawing.Size(300, 160);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnButtonTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFormTest;
        private System.Windows.Forms.Button btnListBoxTest;
        private System.Windows.Forms.Button btnTabControlTest;
        private System.Windows.Forms.Button btnComboBoxTest;
        private System.Windows.Forms.Button btnToolTipTest;
    }
}