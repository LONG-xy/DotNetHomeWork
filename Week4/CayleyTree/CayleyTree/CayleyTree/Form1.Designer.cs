namespace CayleyTree
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_n = new System.Windows.Forms.TextBox();
            this.tb_leng = new System.Windows.Forms.TextBox();
            this.tb_per1 = new System.Windows.Forms.TextBox();
            this.tb_per2 = new System.Windows.Forms.TextBox();
            this.tb_th2 = new System.Windows.Forms.TextBox();
            this.label_Msg = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_th1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(423, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 421);
            this.panel1.TabIndex = 0;
            // 
            // tb_n
            // 
            this.tb_n.Location = new System.Drawing.Point(182, 44);
            this.tb_n.Name = "tb_n";
            this.tb_n.Size = new System.Drawing.Size(100, 25);
            this.tb_n.TabIndex = 1;
            // 
            // tb_leng
            // 
            this.tb_leng.Location = new System.Drawing.Point(182, 108);
            this.tb_leng.Name = "tb_leng";
            this.tb_leng.Size = new System.Drawing.Size(100, 25);
            this.tb_leng.TabIndex = 2;
            // 
            // tb_per1
            // 
            this.tb_per1.Location = new System.Drawing.Point(182, 181);
            this.tb_per1.Name = "tb_per1";
            this.tb_per1.Size = new System.Drawing.Size(100, 25);
            this.tb_per1.TabIndex = 3;
            // 
            // tb_per2
            // 
            this.tb_per2.Location = new System.Drawing.Point(182, 251);
            this.tb_per2.Name = "tb_per2";
            this.tb_per2.Size = new System.Drawing.Size(100, 25);
            this.tb_per2.TabIndex = 4;
            // 
            // tb_th2
            // 
            this.tb_th2.Location = new System.Drawing.Point(182, 411);
            this.tb_th2.Name = "tb_th2";
            this.tb_th2.Size = new System.Drawing.Size(100, 25);
            this.tb_th2.TabIndex = 6;
            // 
            // label_Msg
            // 
            this.label_Msg.AutoSize = true;
            this.label_Msg.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Msg.Location = new System.Drawing.Point(420, 44);
            this.label_Msg.Name = "label_Msg";
            this.label_Msg.Size = new System.Drawing.Size(75, 19);
            this.label_Msg.TabIndex = 7;
            this.label_Msg.Text = "label1";
            this.label_Msg.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(838, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 42);
            this.button1.TabIndex = 8;
            this.button1.Text = "画图";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnDraw_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(172, 468);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 41);
            this.button2.TabIndex = 9;
            this.button2.Text = "选择颜色";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BtnSetColor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(30, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "递归深度";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(30, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "主干长度";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(30, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "右分支长度比";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(30, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "左分支长度比";
            // 
            // tb_th1
            // 
            this.tb_th1.Location = new System.Drawing.Point(182, 338);
            this.tb_th1.Name = "tb_th1";
            this.tb_th1.Size = new System.Drawing.Size(100, 25);
            this.tb_th1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(30, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "右分支角度";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(30, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "左分支角度";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(30, 480);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "画笔颜色";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 545);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_Msg);
            this.Controls.Add(this.tb_th2);
            this.Controls.Add(this.tb_th1);
            this.Controls.Add(this.tb_per2);
            this.Controls.Add(this.tb_per1);
            this.Controls.Add(this.tb_leng);
            this.Controls.Add(this.tb_n);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "CayleyTree";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_n;
        private System.Windows.Forms.TextBox tb_leng;
        private System.Windows.Forms.TextBox tb_per1;
        private System.Windows.Forms.TextBox tb_per2;
        private System.Windows.Forms.TextBox tb_th2;
        private System.Windows.Forms.Label label_Msg;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_th1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

