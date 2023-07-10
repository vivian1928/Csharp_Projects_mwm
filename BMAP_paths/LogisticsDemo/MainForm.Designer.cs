namespace LogisticsDemo
{
    partial class MainForm
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
            this.bMapControl1 = new BMap.NET.WindowsForm.BMapControl();
            this.bTabControl1 = new BMap.NET.WindowsForm.FunctionalControls.BTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bMapControl1
            // 
            this.bMapControl1.BDirectionBoard = null;
            this.bMapControl1.BPlaceBox = null;
            this.bMapControl1.BPlacesBoard = null;
            this.bMapControl1.LoadMode = BMap.NET.LoadMapMode.Cache;
            this.bMapControl1.Location = new System.Drawing.Point(393, 3);
            this.bMapControl1.Mode = BMap.NET.MapMode.Normal;
            this.bMapControl1.Name = "bMapControl1";
            this.bMapControl1.Size = new System.Drawing.Size(632, 599);
            this.bMapControl1.TabIndex = 1;
            this.bMapControl1.Zoom = 12;
            // 
            // bTabControl1
            // 
            this.bTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.bTabControl1.Controls.Add(this.tabPage1);
            this.bTabControl1.Controls.Add(this.tabPage2);
            this.bTabControl1.ItemSize = new System.Drawing.Size(85, 85);
            this.bTabControl1.Location = new System.Drawing.Point(1, -1);
            this.bTabControl1.Multiline = true;
            this.bTabControl1.Name = "bTabControl1";
            this.bTabControl1.SelectedIndex = 0;
            this.bTabControl1.Size = new System.Drawing.Size(389, 700);
            this.bTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(89, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(296, 692);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "行车监控";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(89, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(296, 676);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "车辆事件";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 683);
            this.Controls.Add(this.bMapControl1);
            this.Controls.Add(this.bTabControl1);
            this.Name = "MainForm";
            this.Text = "物流监控";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.bTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BMap.NET.WindowsForm.FunctionalControls.BTabControl bTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private BMap.NET.WindowsForm.BMapControl bMapControl1;
    }
}

