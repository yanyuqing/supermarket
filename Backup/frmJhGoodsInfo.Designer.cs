namespace CHEXC
{
    partial class frmJhGoodsInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJhGoodsInfo));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.txtGoodsID = new System.Windows.Forms.TextBox();
            this.txtJhCompName = new System.Windows.Forms.TextBox();
            this.txtGoodsJhPrice = new System.Windows.Forms.TextBox();
            this.txtGoodsName = new System.Windows.Forms.TextBox();
            this.txtGoodsNum = new System.Windows.Forms.TextBox();
            this.cmbGoodsUnit = new System.Windows.Forms.ComboBox();
            this.txtGoodsSellPrice = new System.Windows.Forms.TextBox();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.txtGoodsNeedPrice = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtGoodsNoPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGoodsRemark = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbDepotName = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolSave = new System.Windows.Forms.ToolStripButton();
            this.toolCancel = new System.Windows.Forms.ToolStripButton();
            this.toolAdd = new System.Windows.Forms.ToolStripButton();
            this.toolAmend = new System.Windows.Forms.ToolStripButton();
            this.tollDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolExit = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(14, 252);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(556, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "商品编号";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "商品名称";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "供应商";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "仓库名称";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "数量";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "进货单价";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "销售单价";
            this.Column7.Name = "Column7";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 12);
            this.label14.TabIndex = 21;
            this.label14.Text = "进货编号：";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 100);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 12);
            this.label16.TabIndex = 22;
            this.label16.Text = "进货单价：";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(16, 128);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 23;
            this.label17.Text = "进货日期：";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(309, 42);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 12);
            this.label19.TabIndex = 24;
            this.label19.Text = "商品名称：";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(309, 128);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 12);
            this.label20.TabIndex = 25;
            this.label20.Text = "进货员工：";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(309, 98);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 12);
            this.label22.TabIndex = 29;
            this.label22.Text = "销售单价：";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(308, 73);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(65, 12);
            this.label23.TabIndex = 28;
            this.label23.Text = "进货数量：";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(16, 155);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(65, 12);
            this.label24.TabIndex = 27;
            this.label24.Text = "所属仓库：";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(7, 73);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(77, 12);
            this.label25.TabIndex = 26;
            this.label25.Text = "供应商名称：";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(308, 155);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(65, 12);
            this.label26.TabIndex = 30;
            this.label26.Text = "应付金额：";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(19, 179);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(65, 12);
            this.label27.TabIndex = 31;
            this.label27.Text = "实付金额：";
            // 
            // txtGoodsID
            // 
            this.txtGoodsID.Location = new System.Drawing.Point(81, 39);
            this.txtGoodsID.MaxLength = 20;
            this.txtGoodsID.Name = "txtGoodsID";
            this.txtGoodsID.Size = new System.Drawing.Size(190, 21);
            this.txtGoodsID.TabIndex = 32;
            // 
            // txtJhCompName
            // 
            this.txtJhCompName.Location = new System.Drawing.Point(81, 66);
            this.txtJhCompName.MaxLength = 50;
            this.txtJhCompName.Name = "txtJhCompName";
            this.txtJhCompName.Size = new System.Drawing.Size(139, 21);
            this.txtJhCompName.TabIndex = 33;
            // 
            // txtGoodsJhPrice
            // 
            this.txtGoodsJhPrice.Location = new System.Drawing.Point(81, 93);
            this.txtGoodsJhPrice.MaxLength = 10;
            this.txtGoodsJhPrice.Name = "txtGoodsJhPrice";
            this.txtGoodsJhPrice.Size = new System.Drawing.Size(190, 21);
            this.txtGoodsJhPrice.TabIndex = 35;
            this.txtGoodsJhPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGoodsJhPrice_KeyPress);
            this.txtGoodsJhPrice.TextChanged += new System.EventHandler(this.txtGoodsJhPrice_TextChanged);
            // 
            // txtGoodsName
            // 
            this.txtGoodsName.Location = new System.Drawing.Point(379, 33);
            this.txtGoodsName.MaxLength = 20;
            this.txtGoodsName.Name = "txtGoodsName";
            this.txtGoodsName.Size = new System.Drawing.Size(190, 21);
            this.txtGoodsName.TabIndex = 36;
            // 
            // txtGoodsNum
            // 
            this.txtGoodsNum.Location = new System.Drawing.Point(379, 64);
            this.txtGoodsNum.MaxLength = 10;
            this.txtGoodsNum.Name = "txtGoodsNum";
            this.txtGoodsNum.Size = new System.Drawing.Size(136, 21);
            this.txtGoodsNum.TabIndex = 37;
            this.txtGoodsNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGoodsNum_KeyPress);
            // 
            // cmbGoodsUnit
            // 
            this.cmbGoodsUnit.FormattingEnabled = true;
            this.cmbGoodsUnit.Items.AddRange(new object[] {
            "个",
            "箱",
            "把",
            "车"});
            this.cmbGoodsUnit.Location = new System.Drawing.Point(521, 66);
            this.cmbGoodsUnit.Name = "cmbGoodsUnit";
            this.cmbGoodsUnit.Size = new System.Drawing.Size(48, 20);
            this.cmbGoodsUnit.TabIndex = 38;
            this.cmbGoodsUnit.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtGoodsSellPrice
            // 
            this.txtGoodsSellPrice.Location = new System.Drawing.Point(379, 94);
            this.txtGoodsSellPrice.MaxLength = 10;
            this.txtGoodsSellPrice.Name = "txtGoodsSellPrice";
            this.txtGoodsSellPrice.Size = new System.Drawing.Size(190, 21);
            this.txtGoodsSellPrice.TabIndex = 39;
            this.txtGoodsSellPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGoodsSellPrice_KeyPress);
            // 
            // txtEmpId
            // 
            this.txtEmpId.Location = new System.Drawing.Point(380, 119);
            this.txtEmpId.MaxLength = 30;
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(190, 21);
            this.txtEmpId.TabIndex = 40;
            // 
            // txtGoodsNeedPrice
            // 
            this.txtGoodsNeedPrice.Enabled = false;
            this.txtGoodsNeedPrice.Location = new System.Drawing.Point(380, 146);
            this.txtGoodsNeedPrice.MaxLength = 10;
            this.txtGoodsNeedPrice.Name = "txtGoodsNeedPrice";
            this.txtGoodsNeedPrice.Size = new System.Drawing.Size(190, 21);
            this.txtGoodsNeedPrice.TabIndex = 41;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(81, 118);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(190, 21);
            this.dateTimePicker1.TabIndex = 42;
            // 
            // txtGoodsNoPrice
            // 
            this.txtGoodsNoPrice.Location = new System.Drawing.Point(81, 173);
            this.txtGoodsNoPrice.MaxLength = 10;
            this.txtGoodsNoPrice.Name = "txtGoodsNoPrice";
            this.txtGoodsNoPrice.Size = new System.Drawing.Size(301, 21);
            this.txtGoodsNoPrice.TabIndex = 44;
            this.txtGoodsNoPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGoodsNoPrice_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 45;
            this.label1.Text = "备注：";
            // 
            // txtGoodsRemark
            // 
            this.txtGoodsRemark.Location = new System.Drawing.Point(81, 200);
            this.txtGoodsRemark.MaxLength = 50;
            this.txtGoodsRemark.Multiline = true;
            this.txtGoodsRemark.Name = "txtGoodsRemark";
            this.txtGoodsRemark.Size = new System.Drawing.Size(301, 43);
            this.txtGoodsRemark.TabIndex = 46;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 23);
            this.button1.TabIndex = 48;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbDepotName
            // 
            this.cmbDepotName.FormattingEnabled = true;
            this.cmbDepotName.Items.AddRange(new object[] {
            "A仓库",
            "烟酒",
            "电器",
            "床上",
            "食品",
            "电动"});
            this.cmbDepotName.Location = new System.Drawing.Point(81, 146);
            this.cmbDepotName.Name = "cmbDepotName";
            this.cmbDepotName.Size = new System.Drawing.Size(190, 20);
            this.cmbDepotName.TabIndex = 49;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSave,
            this.toolCancel,
            this.toolAdd,
            this.toolAmend,
            this.tollDelete,
            this.toolStripSeparator2,
            this.toolExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(597, 25);
            this.toolStrip1.TabIndex = 50;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolSave
            // 
            this.toolSave.Enabled = false;
            this.toolSave.Image = ((System.Drawing.Image)(resources.GetObject("toolSave.Image")));
            this.toolSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSave.Name = "toolSave";
            this.toolSave.Size = new System.Drawing.Size(49, 22);
            this.toolSave.Tag = "1";
            this.toolSave.Text = "保存";
            this.toolSave.Click += new System.EventHandler(this.toolSave_Click);
            // 
            // toolCancel
            // 
            this.toolCancel.Enabled = false;
            this.toolCancel.Image = ((System.Drawing.Image)(resources.GetObject("toolCancel.Image")));
            this.toolCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCancel.Name = "toolCancel";
            this.toolCancel.Size = new System.Drawing.Size(49, 22);
            this.toolCancel.Tag = "2";
            this.toolCancel.Text = "取消";
            this.toolCancel.Click += new System.EventHandler(this.toolCancel_Click);
            // 
            // toolAdd
            // 
            this.toolAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolAdd.Image")));
            this.toolAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAdd.Name = "toolAdd";
            this.toolAdd.Size = new System.Drawing.Size(49, 22);
            this.toolAdd.Tag = "3";
            this.toolAdd.Text = "添加";
            this.toolAdd.Click += new System.EventHandler(this.toolAdd_Click);
            // 
            // toolAmend
            // 
            this.toolAmend.Image = ((System.Drawing.Image)(resources.GetObject("toolAmend.Image")));
            this.toolAmend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAmend.Name = "toolAmend";
            this.toolAmend.Size = new System.Drawing.Size(49, 22);
            this.toolAmend.Tag = "4";
            this.toolAmend.Text = "修改";
            this.toolAmend.Click += new System.EventHandler(this.toolAmend_Click);
            // 
            // tollDelete
            // 
            this.tollDelete.Image = global::CHEXC.Properties.Resources.删除;
            this.tollDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tollDelete.Name = "tollDelete";
            this.tollDelete.Size = new System.Drawing.Size(49, 22);
            this.tollDelete.Text = "删除";
            this.tollDelete.Click += new System.EventHandler(this.tollDelete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolExit
            // 
            this.toolExit.Image = ((System.Drawing.Image)(resources.GetObject("toolExit.Image")));
            this.toolExit.ImageTransparentColor = System.Drawing.SystemColors.Control;
            this.toolExit.Name = "toolExit";
            this.toolExit.Size = new System.Drawing.Size(49, 22);
            this.toolExit.Tag = "7";
            this.toolExit.Text = "退出";
            this.toolExit.Click += new System.EventHandler(this.toolExit_Click);
            // 
            // frmJhGoodsInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 399);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.cmbDepotName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtGoodsRemark);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGoodsNoPrice);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtGoodsNeedPrice);
            this.Controls.Add(this.txtEmpId);
            this.Controls.Add(this.txtGoodsSellPrice);
            this.Controls.Add(this.cmbGoodsUnit);
            this.Controls.Add(this.txtGoodsNum);
            this.Controls.Add(this.txtGoodsName);
            this.Controls.Add(this.txtGoodsJhPrice);
            this.Controls.Add(this.txtJhCompName);
            this.Controls.Add(this.txtGoodsID);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmJhGoodsInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "商品进货信息";
            this.Load += new System.EventHandler(this.frmJhGoodsInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtGoodsID;
        private System.Windows.Forms.TextBox txtGoodsJhPrice;
        private System.Windows.Forms.TextBox txtGoodsName;
        private System.Windows.Forms.TextBox txtGoodsNum;
        private System.Windows.Forms.ComboBox cmbGoodsUnit;
        private System.Windows.Forms.TextBox txtGoodsSellPrice;
        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.TextBox txtGoodsNeedPrice;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtGoodsNoPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGoodsRemark;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txtJhCompName;
        private System.Windows.Forms.ComboBox cmbDepotName;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolSave;
        private System.Windows.Forms.ToolStripButton toolCancel;
        private System.Windows.Forms.ToolStripButton toolAdd;
        private System.Windows.Forms.ToolStripButton toolAmend;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolExit;
        private System.Windows.Forms.ToolStripButton tollDelete;
    }
}