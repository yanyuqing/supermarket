namespace CHEXC
{
    partial class frmMain
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.statuslabMenuInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStockManage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGoodsIn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFind = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuBaseManage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCompany = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuSellManage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSellGoods = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuSellFind = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDepotManage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDepotAlarm = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuDepotFind = new System.Windows.Forms.ToolStripMenuItem();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusUser
            // 
            this.statusUser.BorderStyle = System.Windows.Forms.Border3DStyle.Raised;
            this.statusUser.Name = "statusUser";
            this.statusUser.Size = new System.Drawing.Size(215, 17);
            this.statusUser.Spring = true;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(11, 17);
            this.toolStripStatusLabel1.Text = "|";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(11, 17);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // statusTime
            // 
            this.statusTime.Name = "statusTime";
            this.statusTime.Size = new System.Drawing.Size(215, 17);
            this.statusTime.Spring = true;
            // 
            // statuslabMenuInfo
            // 
            this.statuslabMenuInfo.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.statuslabMenuInfo.Name = "statuslabMenuInfo";
            this.statuslabMenuInfo.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.statuslabMenuInfo.Size = new System.Drawing.Size(215, 17);
            this.statuslabMenuInfo.Spring = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statuslabMenuInfo,
            this.toolStripStatusLabel1,
            this.statusUser,
            this.toolStripStatusLabel2,
            this.statusTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 415);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(684, 22);
            this.statusStrip1.Stretch = false;
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStockManage
            // 
            this.menuStockManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGoodsIn,
            this.toolStripMenuItem2,
            this.menuFind});
            this.menuStockManage.Name = "menuStockManage";
            this.menuStockManage.Size = new System.Drawing.Size(68, 21);
            this.menuStockManage.Text = "进货管理";
            this.menuStockManage.Click += new System.EventHandler(this.menuStockManage_Click);
            // 
            // menuGoodsIn
            // 
            this.menuGoodsIn.Name = "menuGoodsIn";
            this.menuGoodsIn.Size = new System.Drawing.Size(124, 22);
            this.menuGoodsIn.Tag = "5";
            this.menuGoodsIn.Text = "商品进货";
            this.menuGoodsIn.Click += new System.EventHandler(this.menuGoodsIn_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(121, 6);
            // 
            // menuFind
            // 
            this.menuFind.Name = "menuFind";
            this.menuFind.Size = new System.Drawing.Size(124, 22);
            this.menuFind.Tag = "7";
            this.menuFind.Text = "商品查询";
            this.menuFind.Click += new System.EventHandler(this.menuFind_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(133, 6);
            // 
            // menuBaseManage
            // 
            this.menuBaseManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEmployee,
            this.menuCompany,
            this.toolStripMenuItem1});
            this.menuBaseManage.Name = "menuBaseManage";
            this.menuBaseManage.Size = new System.Drawing.Size(68, 21);
            this.menuBaseManage.Text = "基本信息";
            // 
            // menuEmployee
            // 
            this.menuEmployee.Name = "menuEmployee";
            this.menuEmployee.Size = new System.Drawing.Size(136, 22);
            this.menuEmployee.Tag = "1";
            this.menuEmployee.Text = "员工信息";
            this.menuEmployee.Click += new System.EventHandler(this.menuEmployee_Click);
            // 
            // menuCompany
            // 
            this.menuCompany.Name = "menuCompany";
            this.menuCompany.Size = new System.Drawing.Size(136, 22);
            this.menuCompany.Tag = "2";
            this.menuCompany.Text = "供应商信息";
            this.menuCompany.Click += new System.EventHandler(this.menuCompany_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBaseManage,
            this.menuStockManage,
            this.menuSellManage,
            this.menuDepotManage});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuSellManage
            // 
            this.menuSellManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSellGoods,
            this.toolStripMenuItem3,
            this.menuSellFind});
            this.menuSellManage.Name = "menuSellManage";
            this.menuSellManage.Size = new System.Drawing.Size(68, 21);
            this.menuSellManage.Text = "销售管理";
            // 
            // menuSellGoods
            // 
            this.menuSellGoods.Name = "menuSellGoods";
            this.menuSellGoods.Size = new System.Drawing.Size(124, 22);
            this.menuSellGoods.Tag = "8";
            this.menuSellGoods.Text = "商品销售";
            this.menuSellGoods.Click += new System.EventHandler(this.menuSellGoods_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(121, 6);
            // 
            // menuSellFind
            // 
            this.menuSellFind.Name = "menuSellFind";
            this.menuSellFind.Size = new System.Drawing.Size(124, 22);
            this.menuSellFind.Tag = "10";
            this.menuSellFind.Text = "商品退货";
            this.menuSellFind.Click += new System.EventHandler(this.menuSellFind_Click);
            // 
            // menuDepotManage
            // 
            this.menuDepotManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDepotAlarm,
            this.toolStripMenuItem4,
            this.menuDepotFind});
            this.menuDepotManage.Name = "menuDepotManage";
            this.menuDepotManage.Size = new System.Drawing.Size(68, 21);
            this.menuDepotManage.Text = "库存管理";
            // 
            // menuDepotAlarm
            // 
            this.menuDepotAlarm.Name = "menuDepotAlarm";
            this.menuDepotAlarm.Size = new System.Drawing.Size(152, 22);
            this.menuDepotAlarm.Tag = "12";
            this.menuDepotAlarm.Text = "库存警告";
            this.menuDepotAlarm.Click += new System.EventHandler(this.menuDepotAlarm_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(121, 6);
            // 
            // menuDepotFind
            // 
            this.menuDepotFind.Name = "menuDepotFind";
            this.menuDepotFind.Size = new System.Drawing.Size(152, 22);
            this.menuDepotFind.Tag = "13";
            this.menuDepotFind.Text = "查询库存";
            this.menuDepotFind.Click += new System.EventHandler(this.menuDepotFind_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::CHEXC.Properties.Resources.bg1;
            this.ClientSize = new System.Drawing.Size(684, 437);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SY超市进销存管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripStatusLabel statusUser;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel statusTime;
        private System.Windows.Forms.ToolStripStatusLabel statuslabMenuInfo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuStockManage;
        private System.Windows.Forms.ToolStripMenuItem menuGoodsIn;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem menuFind;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuBaseManage;
        private System.Windows.Forms.ToolStripMenuItem menuEmployee;
        private System.Windows.Forms.ToolStripMenuItem menuCompany;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuSellManage;
        private System.Windows.Forms.ToolStripMenuItem menuSellGoods;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem menuSellFind;
        private System.Windows.Forms.ToolStripMenuItem menuDepotManage;
        private System.Windows.Forms.ToolStripMenuItem menuDepotAlarm;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem menuDepotFind;
        private System.Windows.Forms.Timer timer2;
    }
}