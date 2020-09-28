﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OrderManagement_Winform.Order;
using System.IO;

namespace OrderManagement_Winform
{


        public partial class Form1 : Form
        {
            private OrderService _service;
            private Order _currentOrder = null;

            public Form1()
            {
                InitializeComponent();
            }


            private void Form1_Load(object sender, EventArgs e)
            {
                _service = new OrderService();
                Goods goods = new Goods();

                bs_OrderList.DataSource = _service.OrderList;
                dataGridView_OrderList.DataSource = bs_OrderList;

                dataGridView_OrderItem.DataSource = bs_OrderItem;

                comboBox_Goods.DataSource = goods.GoodsList;
                comboBox_Goods.DisplayMember = "name";

                try
                {
                    _service.Import();
                    Console.WriteLine("成功读取了存档数据。");
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("未找到存档数据。");
                }

                var o = new Order("顾客A");
                _service.AddOrder(o);
                _currentOrder = o;
                _currentOrder.AddItem("苹果", 1);
                _currentOrder.AddItem("百香果", 2);

                bs_OrderList.ResetBindings(false);


                o = new Order("顾客B");
                _service.AddOrder(o);
                _currentOrder = o;
                _currentOrder.AddItem("红葡萄", 4);
            bs_OrderList.ResetBindings(false);

            }

            private int _selectedOrder = 0;

            private void dataGridView_OrderList_SelectionChanged(object sender, EventArgs e)
            {

                _selectedOrder = dataGridView_OrderList.CurrentCellAddress.Y;
                if (_selectedOrder != -1)
                {
                    bs_OrderItem.DataSource = _service.OrderList[_selectedOrder].Items;
                    bs_OrderItem.ResetBindings(false);
                    tb_Customer.Text = dataGridView_OrderList.CurrentRow.Cells[0].Value.ToString();
                    _currentOrder = _service.OrderList[_selectedOrder];
                }

            }

            private string _product;
            private void dataGridView_OrderItem_SelectionChanged(object sender, EventArgs e)
            {
                if (dataGridView_OrderItem.CurrentRow != null)
                {
                    _product = dataGridView_OrderItem.CurrentRow.Cells[0].Value.ToString();
                    comboBox_Goods.SelectedIndex = comboBox_Goods.FindStringExact(_product);
                    tb_num.Text = dataGridView_OrderItem.CurrentRow.Cells[1].Value.ToString();
                }
            }

            private void btn_AddOrder_Click(object sender, EventArgs e)
            {
                if (tb_Customer.Text == "")
                {
                    tb_Prompt.Text = "请输入顾客名。";
                }
                else
                {
                    try
                    {
                        var o = new Order(tb_Customer.Text);
                        _service.AddOrder(o);
                        _currentOrder = o;
                        tb_Prompt.Text = "系统已成功为你创建了新订单。继续添加订单明细吧。";
                        bs_OrderList.ResetBindings(false);
                    }
                    catch (OrderExistsException ex)
                    {
                        tb_Prompt.Text = ex.Message;
                    }

                }

            }

            private void btn_DelOrder_Click(object sender, EventArgs e)
            {

                try
                {
                    var ID = dataGridView_OrderList.CurrentRow.Cells[1].Value.ToString();
                    _service.DelOrder(ID);
                    bs_OrderList.ResetBindings(false);
                }
                catch
                {
                    tb_Prompt.Text = "删除订单失败，请重新选择再试。";
                }
            }

            private void btn_AddP_Click(object sender, EventArgs e)
            {
                if (_currentOrder == null)
                {
                    tb_Prompt.Text = "错误！请先选中订单后再尝试添加订单明细。";
                }
                else
                {
                    string productName = comboBox_Goods.Text;
                    int productNum = Convert.ToInt32(tb_num.Text);
                    try
                    {
                        _currentOrder.AddItem(productName, productNum);
                        bs_OrderList.ResetBindings(false);
                        bs_OrderItem.ResetBindings(false);

                    }
                    catch (ItemExistsException)
                    {
                        tb_Prompt.Text = "添加商品失败，当前商品已存在。如需修改请点击修改按钮。";
                    }
                    catch (GoodNotExistsException)
                    {
                        tb_Prompt.Text = "添加商品失败，尝试添加的商品不存在。";
                    }

                }

            }

            private void btn_MdP_Click(object sender, EventArgs e)
            {
                if (_currentOrder == null)
                {
                    tb_Prompt.Text = "错误！请先选中订单后再尝试修改订单明细。";
                }
                else
                {
                    string pname = comboBox_Goods.Text;
                    int pnum = Convert.ToInt32(tb_num.Text);
                    try
                    {
                        _service.ModifyOrder(_currentOrder.ID, pname, pnum);
                        bs_OrderList.ResetBindings(false);
                        bs_OrderItem.ResetBindings(false);
                    }
                    catch (OrderInvalidException)
                    {
                        tb_Prompt.Text = "修改订单失败，请检查订单号是否正确。";
                    }
                    catch (ItemInvalidException)
                    {
                        tb_Prompt.Text = "修改订单失败，请检查商品名称是否正确。";
                    }
                }

            }

            private void btn_DelP_Click(object sender, EventArgs e)
            {
                if (_currentOrder == null)
                {
                    tb_Prompt.Text = "错误！请先选中订单后再尝试删除订单明细。";
                }
                else
                {
                    string productName = comboBox_Goods.Text;
                    try
                    {
                        _service.ModifyOrder(_currentOrder.ID, productName, 0);
                        bs_OrderList.ResetBindings(false);
                        bs_OrderItem.ResetBindings(false);
                    }
                    catch (OrderInvalidException)
                    {
                        tb_Prompt.Text = "删除订单失败，请检查订单号是否正确。";
                    }
                    catch (ItemInvalidException)
                    {
                        tb_Prompt.Text = "删除订单失败，请检查商品名称是否正确。";
                    }
                }
            }

      
        private void btn_QPn_Click(object sender, EventArgs e)
            {
                if (tb_Query.Text == "")
                {
                    bs_OrderList.DataSource = _service.OrderList;
                    bs_OrderList.ResetBindings(false);
                }
                else
                {
                    var re = _service.Query("Product", tb_Query.Text);
                    bs_OrderList.DataSource = re;
                    bs_OrderList.ResetBindings(false);
                }
            }

            private void btn_QC_Click(object sender, EventArgs e)
            {
                if (tb_Query.Text == "")
                {
                    bs_OrderList.DataSource = _service.OrderList;
                    bs_OrderList.ResetBindings(false);
                }
                else
                {
                    var re = _service.Query("Customer", tb_Query.Text);
                    bs_OrderList.DataSource = re;
                    bs_OrderList.ResetBindings(false);
                }

            }
    }
}
