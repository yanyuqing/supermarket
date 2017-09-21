namespace CHEXC
{
    partial class frmThGoodsInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThGoodsInfo));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolSave = new System.Windows.Forms.ToolStripButton();
            this.toolCancel = new System.Windows.Forms.ToolStripButton();
            this.toolAdd = new System.Windows.Forms.ToolStripButton();
            this.toolAmend = new System.Windows.Forms.ToolStripButton();
            this.toolDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolExit = new System.Windows.Forms.ToolStripButton();
            this.txtThGoodsID = new System.Windows.Forms.TextBox();
            this.txtSellID = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtThGoodsName = new System.Windows.Forms.TextBox();
            this.txtThGoodsPrice = new System.Windows.Forms.TextBox();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.txtDataTime = new System.Windows.Forms.TextBox();
            this.txThGoodsNum = new System.Windows.Forms.TextBox();
            this.txtThHasPay = new System.Windows.Forms.TextBox();
            this.txtThNeedPay = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtThGoodsResult = new System.Windows.Forms.TextBox();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.daThGoodsTime = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column2,
            this.Column4,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(12, 237);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(449, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "退货编号";
            this.Column1.Name = "Column1";
            this.Column1.Width = 120;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "销售编号";
            this.Column5.Name = "Column5";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "商品名称";
            this.Column2.Name = "Column2";
            this.Column2.Width = 110;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "退货单价";
            this.Column4.Name = "Column4";
            this.Column4.Width = 110;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "退货数量";
            this.Column3.Name = "Column3";
            this.Column3.Width = 105;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "退货编号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "销售编号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "商品名称：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "销售数量：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "销售日期：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "退货数量：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "应付金额：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(219, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 9;
            this.label8.Text = "销售单价：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(219, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 10;
            this.label9.Text = "退货单价：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(219, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 11;
            this.label10.Text = "实付金额：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 12;
            this.label11.Text = "退货原因：";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSave,
            this.toolCancel,
            this.toolAdd,
            this.toolAmend,
            this.toolDelete,
            this.toolStripSeparator2,
            this.toolExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(486, 25);
            this.toolStrip1.TabIndex = 21;
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
            // toolDelete
            // 
            this.toolDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolDelete.Image")));
            this.toolDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDelete.Name = "toolDelete";
            this.toolDelete.Size = new System.Drawing.Size(49, 22);
            this.toolDelete.Text = "删除";
            this.toolDelete.Click += new System.EventHandler(this.toolDelete_Click);
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
            // txtThGoodsID
            // 
            this.txtThGoodsID.Enabled = false;
            this.txtThGoodsID.Location = new System.Drawing.Point(81, 29);
            this.txtThGoodsID.Name = "txtThGoodsID";
            this.txtThGoodsID.Size = new System.Drawing.Size(127, 21);
            this.txtThGoodsID.TabIndex = 22;
            // 
            // txtSellID
            // 
            this.txtSellID.Enabled = false;
            this.txtSellID.Location = new System.Drawing.Point(290, 35);
            this.txtSellID.Name = "txtSellID";
            this.txtSellID.Size = new System.Drawing.Size(127, 21);
            this.txtSellID.TabIndex = 23;
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(290, 89);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(171, 21);
            this.txtPrice.TabIndex = 25;
            // 
            // txtThGoodsName
            // 
            this.txtThGoodsName.Enabled = false;
            this.txtThGoodsName.Location = new System.Drawing.Point(81, 62);
            this.txtThGoodsName.Name = "txtThGoodsName";
            this.txtThGoodsName.Size = new System.Drawing.Size(127, 21);
            this.txtThGoodsName.TabIndex = 26;
            // 
            // txtThGoodsPrice
            // 
            this.txtThGoodsPrice.Location = new System.Drawing.Point(290, 116);
            this.txtThGoodsPrice.Name = "txtThGoodsPrice";
            this.txtThGoodsPrice.Size = new System.Drawing.Size(171, 21);
            this.txtThGoodsPrice.TabIndex = 27;
            this.txtThGoodsPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtThGoodsPrice_KeyPress);
            // 
            // txtnum
            // 
            this.txtnum.Enabled = false;
            this.txtnum.Location = new System.Drawing.Point(81, 89);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(127, 21);
            this.txtnum.TabIndex = 28;
            // 
            // txtDataTime
            // 
            this.txtDataTime.Enabled = false;
            this.txtDataTime.Location = new System.Drawing.Point(290, 62);
            this.txtDataTime.Name = "txtDataTime";
            this.txtDataTime.Size = new System.Drawing.Size(171, 21);
            this.txtDataTime.TabIndex = 30;
            // 
            // txThGoodsNum
            // 
            this.txThGoodsNum.Location = new System.Drawing.Point(81, 116);
            this.txThGoodsNum.Name = "txThGoodsNum";
            this.txThGoodsNum.Size = new System.Drawing.Size(127, 21);
            this.txThGoodsNum.TabIndex = 31;
            this.txThGoodsNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txThGoodsNum_KeyPress);
            // 
            // txtThHasPay
            // 
            this.txtThHasPay.Location = new System.Drawing.Point(81, 139);
            this.txtThHasPay.Name = "txtThHasPay";
            this.txtThHasPay.Size = new System.Drawing.Size(127, 21);
            this.txtThHasPay.TabIndex = 32;
            this.txtThHasPay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtThHasPay_KeyPress);
            // 
            // txtThNeedPay
            // 
            this.txtThNeedPay.Location = new System.Drawing.Point(290, 145);
            this.txtThNeedPay.Name = "txtThNeedPay";
            this.txtThNeedPay.Size = new System.Drawing.Size(171, 21);
            this.txtThNeedPay.TabIndex = 33;
            this.txtThNeedPay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtThNeedPay_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(233, 180);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 29;
            this.label12.Text = "员工：";
            // 
            // txtThGoodsResult
            // 
            this.txtThGoodsResult.Location = new System.Drawing.Point(81, 177);
            this.txtThGoodsResult.Multiline = true;
            this.txtThGoodsResult.Name = "txtThGoodsResult";
            this.txtThGoodsResult.Size = new System.Drawing.Size(127, 54);
            this.txtThGoodsResult.TabIndex = 34;
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(290, 177);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(171, 21);
            this.txtEmpID.TabIndex = 35;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(219, 208);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 36;
            this.label13.Text = "退货时间：";
            // 
            // daThGoodsTime
            // 
            this.daThGoodsTime.Location = new System.Drawing.Point(290, 204);
            this.daThGoodsTime.Name = "daThGoodsTime";
            this.daThGoodsTime.Size = new System.Drawing.Size(171, 21);
            this.daThGoodsTime.TabIndex = 37;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(418, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 23);
            this.button2.TabIndex = 38;
            this.button2.Text = "..";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmThGoodsInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 424);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.daThGoodsTime);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.txtThGoodsResult);
            this.Controls.Add(this.txtThNeedPay);
            this.Controls.Add(this.txtThHasPay);
            this.Controls.Add(this.txThGoodsNum);
            this.Controls.Add(this.txtDataTime);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.txtThGoodsPrice);
            this.Controls.Add(this.txtThGoodsName);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtSellID);
            this.Controls.Add(this.txtThGoodsID);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmThGoodsInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "商品退货信息";
            this.Load += new System.EventHandler(this.frmThGoodsInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolSave;
        private System.Windows.Forms.ToolStripButton toolCancel;
        private System.Windows.Forms.ToolStripButton toolAdd;
        private System.Windows.Forms.ToolStripButton toolAmend;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolExit;
        private System.Windows.Forms.TextBox txtThGoodsID;
        private System.Windows.Forms.TextBox txtThGoodsPrice;
        private System.Windows.Forms.TextBox txThGoodsNum;
        private System.Windows.Forms.TextBox txtThHasPay;
        private System.Windows.Forms.TextBox txtThNeedPay;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtThGoodsResult;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker daThGoodsTime;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox txtSellID;
        public System.Windows.Forms.TextBox txtPrice;
        public System.Windows.Forms.TextBox txtThGoodsName;
        public System.Windows.Forms.TextBox txtnum;
        public System.Windows.Forms.TextBox txtDataTime;
        private System.Windows.Forms.ToolStripButton toolDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}