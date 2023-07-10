using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BMap.NET.WinformDemo
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Sqlconn = "Data Source=(local);User ID=sa;Password=sa;Initial Catalog=Logistics;";
            SqlConnection conn;
            SqlCommand comm = new SqlCommand();
            SqlDataReader dr;
            SqlDataAdapter adapter = new SqlDataAdapter();
            if (textBox1.TextLength != 0 && !textBox1.Text.Equals("请输入车牌号")) { 
                if(textBox2.TextLength != 0 && !textBox2.Text.Equals("请输入司机姓名"))
                {
                    conn = new SqlConnection(Sqlconn);
                    conn.Open();
                    //设置命令对象
                    comm.Connection = conn;
                    comm.CommandText = "select * from Vehical where vehic_no like '" + textBox1.Text + "%' and driver_name like'" + textBox2.Text + "%'";
                    //设置数据适配器对象
                    adapter.SelectCommand = comm;
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    logisticsDataSet.Clear();//清除数据集中所有表的所有行
                    adapter.Fill(logisticsDataSet, "Vehical");
                    dataGridView1.DataSource = logisticsDataSet.Tables["Vehical"];
                }
                else
                {
                    conn = new SqlConnection(Sqlconn);
                    conn.Open();
                    //设置命令对象
                    comm.Connection = conn;
                    comm.CommandText = "select * from Vehical where vehic_no like '" + textBox1.Text + "%'";
                    //设置数据适配器对象
                    adapter.SelectCommand = comm;
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    logisticsDataSet.Clear();//清除数据集中所有表的所有行
                    adapter.Fill(logisticsDataSet, "Vehical");
                    dataGridView1.DataSource = logisticsDataSet.Tables["Vehical"];
                }
            }else if(textBox2.TextLength != 0 && !textBox2.Text.Equals("请输入司机姓名"))
            {
                conn = new SqlConnection(Sqlconn);
                conn.Open();
                //设置命令对象
                comm.Connection = conn;
                comm.CommandText = "select * from Vehical where driver_name like '" + textBox2.Text + "%'";
                //设置数据适配器对象
                adapter.SelectCommand = comm;
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                logisticsDataSet.Clear();//清除数据集中所有表的所有行
                adapter.Fill(logisticsDataSet, "Vehical");
                dataGridView1.DataSource = logisticsDataSet.Tables["Vehical"];
            }

        }

        private void bTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(bMapControl1.Visible && !panel1.Visible)
            {
                bMapControl1.Visible = false;
                panel1.Visible = true;
            }
            else
            {
                bMapControl1.Visible = true;
                panel1.Visible = false;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“logisticsDataSet.Vehical”中。您可以根据需要移动或删除它。
            this.vehicalTableAdapter.Fill(this.logisticsDataSet.Vehical);

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.ForeColor = Color.Black;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0)
            {
                textBox1.Text = "请输入车牌号";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox2.ForeColor = Color.Black;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.TextLength == 0)
            {
                textBox2.Text = "请输入司机姓名";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}
