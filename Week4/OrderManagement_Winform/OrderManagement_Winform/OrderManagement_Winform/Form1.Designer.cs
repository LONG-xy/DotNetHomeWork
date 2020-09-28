namespace OrderManagement_Winform
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView_OrderList = new System.Windows.Forms.DataGridView();
            this.dataGridView_OrderItem = new System.Windows.Forms.DataGridView();
            this.bs_OrderList = new System.Windows.Forms.BindingSource(this.components);
            this.bs_OrderItem = new System.Windows.Forms.BindingSource(this.components);
            this.tb_Customer = new System.Windows.Forms.TextBox();
            this.tb_num = new System.Windows.Forms.TextBox();
            this.tb_Prompt = new System.Windows.Forms.TextBox();
            this.tb_Query = new System.Windows.Forms.TextBox();
            this.comboBox_Goods = new System.Windows.Forms.ComboBox();
            this.btn_AddOrder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_DelOrder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_customer = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_MdP = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OrderList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OrderItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_OrderList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_OrderItem)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_OrderList
            // 
            this.dataGridView_OrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_OrderList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_OrderList.Location = new System.Drawing.Point(3, 24);
            this.dataGridView_OrderList.Name = "dataGridView_OrderList";
            this.dataGridView_OrderList.RowHeadersWidth = 51;
            this.dataGridView_OrderList.RowTemplate.Height = 27;
            this.dataGridView_OrderList.Size = new System.Drawing.Size(475, 356);
            this.dataGridView_OrderList.TabIndex = 0;
            this.dataGridView_OrderList.SelectionChanged += new System.EventHandler(this.dataGridView_OrderList_SelectionChanged);
            // 
            // dataGridView_OrderItem
            // 
            this.dataGridView_OrderItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_OrderItem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_OrderItem.Location = new System.Drawing.Point(3, 85);
            this.dataGridView_OrderItem.Name = "dataGridView_OrderItem";
            this.dataGridView_OrderItem.RowHeadersWidth = 51;
            this.dataGridView_OrderItem.RowTemplate.Height = 27;
            this.dataGridView_OrderItem.Size = new System.Drawing.Size(448, 347);
            this.dataGridView_OrderItem.TabIndex = 1;
            this.dataGridView_OrderItem.SelectionChanged += new System.EventHandler(this.dataGridView_OrderItem_SelectionChanged);
            // 
            // tb_Customer
            // 
            this.tb_Customer.Location = new System.Drawing.Point(75, 30);
            this.tb_Customer.Name = "tb_Customer";
            this.tb_Customer.Size = new System.Drawing.Size(100, 25);
            this.tb_Customer.TabIndex = 2;
            // 
            // tb_num
            // 
            this.tb_num.Location = new System.Drawing.Point(547, 28);
            this.tb_num.Name = "tb_num";
            this.tb_num.Size = new System.Drawing.Size(100, 25);
            this.tb_num.TabIndex = 3;
            // 
            // tb_Prompt
            // 
            this.tb_Prompt.Location = new System.Drawing.Point(10, 15);
            this.tb_Prompt.Name = "tb_Prompt";
            this.tb_Prompt.Size = new System.Drawing.Size(480, 25);
            this.tb_Prompt.TabIndex = 4;
            // 
            // tb_Query
            // 
            this.tb_Query.Location = new System.Drawing.Point(75, 78);
            this.tb_Query.Name = "tb_Query";
            this.tb_Query.Size = new System.Drawing.Size(100, 25);
            this.tb_Query.TabIndex = 5;
            // 
            // comboBox_Goods
            // 
            this.comboBox_Goods.FormattingEnabled = true;
            this.comboBox_Goods.Location = new System.Drawing.Point(312, 34);
            this.comboBox_Goods.Name = "comboBox_Goods";
            this.comboBox_Goods.Size = new System.Drawing.Size(103, 23);
            this.comboBox_Goods.TabIndex = 6;
            // 
            // btn_AddOrder
            // 
            this.btn_AddOrder.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_AddOrder.Location = new System.Drawing.Point(697, 30);
            this.btn_AddOrder.Name = "btn_AddOrder";
            this.btn_AddOrder.Size = new System.Drawing.Size(108, 35);
            this.btn_AddOrder.TabIndex = 7;
            this.btn_AddOrder.Text = "添加订单";
            this.btn_AddOrder.UseVisualStyleBackColor = true;
            this.btn_AddOrder.Click += new System.EventHandler(this.btn_AddOrder_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btn_DelOrder);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_AddOrder);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lb_customer);
            this.panel1.Controls.Add(this.comboBox_Goods);
            this.panel1.Controls.Add(this.tb_Customer);
            this.panel1.Controls.Add(this.tb_num);
            this.panel1.Controls.Add(this.tb_Query);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 120);
            this.panel1.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(481, 71);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(166, 35);
            this.button4.TabIndex = 11;
            this.button4.Text = "查询(按产品）";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btn_QPn_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(251, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 35);
            this.button3.TabIndex = 10;
            this.button3.Text = "查询(按顾客)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btn_QC_Click);
            // 
            // btn_DelOrder
            // 
            this.btn_DelOrder.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_DelOrder.Location = new System.Drawing.Point(845, 27);
            this.btn_DelOrder.Name = "btn_DelOrder";
            this.btn_DelOrder.Size = new System.Drawing.Size(108, 34);
            this.btn_DelOrder.TabIndex = 9;
            this.btn_DelOrder.Text = "删除订单";
            this.btn_DelOrder.UseVisualStyleBackColor = true;
            this.btn_DelOrder.Click += new System.EventHandler(this.btn_DelOrder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(477, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "数量";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(247, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "商品";
            // 
            // lb_customer
            // 
            this.lb_customer.AutoSize = true;
            this.lb_customer.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_customer.Location = new System.Drawing.Point(20, 31);
            this.lb_customer.Name = "lb_customer";
            this.lb_customer.Size = new System.Drawing.Size(49, 19);
            this.lb_customer.TabIndex = 6;
            this.lb_customer.Text = "顾客";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_MdP);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dataGridView_OrderItem);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(526, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 435);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "订单明细";
            // 
            // btn_MdP
            // 
            this.btn_MdP.Location = new System.Drawing.Point(234, 28);
            this.btn_MdP.Name = "btn_MdP";
            this.btn_MdP.Size = new System.Drawing.Size(65, 34);
            this.btn_MdP.TabIndex = 11;
            this.btn_MdP.Text = "修改";
            this.btn_MdP.UseVisualStyleBackColor = true;
            this.btn_MdP.Click += new System.EventHandler(this.btn_MdP_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(96, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 35);
            this.button2.TabIndex = 10;
            this.button2.Text = "添加";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn_AddP_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "删除";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_DelP_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView_OrderList);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(12, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(481, 383);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "订单";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.tb_Prompt);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(992, 453);
            this.panel2.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 579);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "订单管理系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OrderList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OrderItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_OrderList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_OrderItem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_OrderList;
        private System.Windows.Forms.DataGridView dataGridView_OrderItem;
        private System.Windows.Forms.BindingSource bs_OrderList;
        private System.Windows.Forms.BindingSource bs_OrderItem;
        private System.Windows.Forms.TextBox tb_Customer;
        private System.Windows.Forms.TextBox tb_num;
        private System.Windows.Forms.TextBox tb_Prompt;
        private System.Windows.Forms.TextBox tb_Query;
        private System.Windows.Forms.ComboBox comboBox_Goods;
        private System.Windows.Forms.Button btn_AddOrder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_customer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_DelOrder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_MdP;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
    }
}

