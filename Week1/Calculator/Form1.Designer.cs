namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.com_op = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtn = new System.Windows.Forms.TextBox();
            this.btn_cal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(47, 74);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(100, 25);
            this.txta.TabIndex = 0;
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(264, 72);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(100, 25);
            this.txtb.TabIndex = 1;
            // 
            // com_op
            // 
            this.com_op.FormattingEnabled = true;
            this.com_op.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "%"});
            this.com_op.Location = new System.Drawing.Point(179, 74);
            this.com_op.Name = "com_op";
            this.com_op.Size = new System.Drawing.Size(46, 23);
            this.com_op.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(397, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "=";
            // 
            // txtn
            // 
            this.txtn.Location = new System.Drawing.Point(440, 74);
            this.txtn.Name = "txtn";
            this.txtn.Size = new System.Drawing.Size(100, 25);
            this.txtn.TabIndex = 4;
            // 
            // btn_cal
            // 
            this.btn_cal.Location = new System.Drawing.Point(440, 154);
            this.btn_cal.Name = "btn_cal";
            this.btn_cal.Size = new System.Drawing.Size(75, 23);
            this.btn_cal.TabIndex = 5;
            this.btn_cal.Text = "计算";
            this.btn_cal.UseVisualStyleBackColor = true;
            this.btn_cal.Click += new System.EventHandler(this.btn_cal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 250);
            this.Controls.Add(this.btn_cal);
            this.Controls.Add(this.txtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.com_op);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txta);
            this.Name = "Form1";
            this.Text = "简易计算器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.ComboBox com_op;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtn;
        private System.Windows.Forms.Button btn_cal;
    }
}

