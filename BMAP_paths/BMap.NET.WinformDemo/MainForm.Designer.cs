namespace BMap.NET.WinformDemo
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
            this.components = new System.ComponentModel.Container();
            this.bTabControl1 = new BMap.NET.WindowsForm.FunctionalControls.BTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bDirectionBoard1 = new BMap.NET.WindowsForm.BDirectionBoard();
            this.bMapControl1 = new BMap.NET.WindowsForm.BMapControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.affairnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drivernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.affairDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehiclatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehiclngDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logisticsDataSet = new BMap.NET.WinformDemo.LogisticsDataSet();
            this.vehicalTableAdapter = new BMap.NET.WinformDemo.LogisticsDataSetTableAdapters.VehicalTableAdapter();
            this.bTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logisticsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // bTabControl1
            // 
            this.bTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.bTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bTabControl1.Controls.Add(this.tabPage1);
            this.bTabControl1.Controls.Add(this.tabPage2);
            this.bTabControl1.ItemSize = new System.Drawing.Size(85, 85);
            this.bTabControl1.Location = new System.Drawing.Point(0, 0);
            this.bTabControl1.Multiline = true;
            this.bTabControl1.Name = "bTabControl1";
            this.bTabControl1.SelectedIndex = 0;
            this.bTabControl1.Size = new System.Drawing.Size(389, 693);
            this.bTabControl1.TabIndex = 0;
            this.bTabControl1.SelectedIndexChanged += new System.EventHandler(this.bTabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bDirectionBoard1);
            this.tabPage1.Location = new System.Drawing.Point(89, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(296, 685);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "行车监控";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // bDirectionBoard1
            // 
            this.bDirectionBoard1.BackColor = System.Drawing.Color.White;
            this.bDirectionBoard1.BMapControl = this.bMapControl1;
            this.bDirectionBoard1.BPlacesBoard = null;
            this.bDirectionBoard1.CurrentCity = null;
            this.bDirectionBoard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bDirectionBoard1.Location = new System.Drawing.Point(3, 3);
            this.bDirectionBoard1.LocationDestinaton1 = null;
            this.bDirectionBoard1.LocationSource1 = null;
            this.bDirectionBoard1.Name = "bDirectionBoard1";
            this.bDirectionBoard1.Size = new System.Drawing.Size(290, 679);
            this.bDirectionBoard1.TabIndex = 1;
            // 
            // bMapControl1
            // 
            this.bMapControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bMapControl1.BDirectionBoard = this.bDirectionBoard1;
            this.bMapControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bMapControl1.BPlaceBox = null;
            this.bMapControl1.BPlacesBoard = null;
            this.bMapControl1.LoadMode = BMap.NET.LoadMapMode.CacheServer;
            this.bMapControl1.Location = new System.Drawing.Point(388, 0);
            this.bMapControl1.Mode = BMap.NET.MapMode.Normal;
            this.bMapControl1.Name = "bMapControl1";
            this.bMapControl1.Size = new System.Drawing.Size(632, 681);
            this.bMapControl1.TabIndex = 1;
            this.bMapControl1.Zoom = 12;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(89, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(296, 685);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "车辆事件";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 10F);
            this.button1.Location = new System.Drawing.Point(162, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("宋体", 11F);
            this.textBox2.ForeColor = System.Drawing.Color.Gray;
            this.textBox2.Location = new System.Drawing.Point(42, 252);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(211, 25);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "请输入司机姓名";
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(39, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "司机姓名：";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 11F);
            this.textBox1.ForeColor = System.Drawing.Color.Gray;
            this.textBox1.Location = new System.Drawing.Point(42, 147);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 25);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "请输入车牌号";
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(39, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "车牌号：";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(37, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 683);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.affairnoDataGridViewTextBoxColumn,
            this.vehicnoDataGridViewTextBoxColumn,
            this.drivernameDataGridViewTextBoxColumn,
            this.affairDataGridViewTextBoxColumn,
            this.vehiclatDataGridViewTextBoxColumn,
            this.vehiclngDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vehicalBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(134, 241);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(700, 181);
            this.dataGridView1.TabIndex = 0;
            // 
            // affairnoDataGridViewTextBoxColumn
            // 
            this.affairnoDataGridViewTextBoxColumn.DataPropertyName = "affair_no";
            this.affairnoDataGridViewTextBoxColumn.HeaderText = "事件编号";
            this.affairnoDataGridViewTextBoxColumn.Name = "affairnoDataGridViewTextBoxColumn";
            this.affairnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vehicnoDataGridViewTextBoxColumn
            // 
            this.vehicnoDataGridViewTextBoxColumn.DataPropertyName = "vehic_no";
            this.vehicnoDataGridViewTextBoxColumn.HeaderText = "车牌号";
            this.vehicnoDataGridViewTextBoxColumn.Name = "vehicnoDataGridViewTextBoxColumn";
            // 
            // drivernameDataGridViewTextBoxColumn
            // 
            this.drivernameDataGridViewTextBoxColumn.DataPropertyName = "driver_name";
            this.drivernameDataGridViewTextBoxColumn.HeaderText = "司机姓名";
            this.drivernameDataGridViewTextBoxColumn.Name = "drivernameDataGridViewTextBoxColumn";
            // 
            // affairDataGridViewTextBoxColumn
            // 
            this.affairDataGridViewTextBoxColumn.DataPropertyName = "affair";
            this.affairDataGridViewTextBoxColumn.HeaderText = "事件概述";
            this.affairDataGridViewTextBoxColumn.Name = "affairDataGridViewTextBoxColumn";
            // 
            // vehiclatDataGridViewTextBoxColumn
            // 
            this.vehiclatDataGridViewTextBoxColumn.DataPropertyName = "vehic_lat";
            this.vehiclatDataGridViewTextBoxColumn.HeaderText = "车辆纬度";
            this.vehiclatDataGridViewTextBoxColumn.Name = "vehiclatDataGridViewTextBoxColumn";
            // 
            // vehiclngDataGridViewTextBoxColumn
            // 
            this.vehiclngDataGridViewTextBoxColumn.DataPropertyName = "vehic_lng";
            this.vehiclngDataGridViewTextBoxColumn.HeaderText = "车辆经度";
            this.vehiclngDataGridViewTextBoxColumn.Name = "vehiclngDataGridViewTextBoxColumn";
            // 
            // vehicalBindingSource
            // 
            this.vehicalBindingSource.DataMember = "Vehical";
            this.vehicalBindingSource.DataSource = this.logisticsDataSet;
            // 
            // logisticsDataSet
            // 
            this.logisticsDataSet.DataSetName = "LogisticsDataSet";
            this.logisticsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehicalTableAdapter
            // 
            this.vehicalTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 683);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bMapControl1);
            this.Controls.Add(this.bTabControl1);
            this.Name = "MainForm";
            this.Text = "物流监控";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.bTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logisticsDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WindowsForm.FunctionalControls.BTabControl bTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private WindowsForm.BMapControl bMapControl1;
        private WindowsForm.BDirectionBoard bDirectionBoard1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private LogisticsDataSet logisticsDataSet;
        private System.Windows.Forms.BindingSource vehicalBindingSource;
        private LogisticsDataSetTableAdapters.VehicalTableAdapter vehicalTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn affairnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drivernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn affairDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehiclatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehiclngDataGridViewTextBoxColumn;
    }
}