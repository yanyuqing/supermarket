namespace CHEXC
{
    partial class frmDataReole
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
            this.label1 = new System.Windows.Forms.Label();
            this.bntOpent = new System.Windows.Forms.Button();
            this.textPaht = new System.Windows.Forms.TextBox();
            this.bntOk = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "数据备份后的文件路径：";
            // 
            // bntOpent
            // 
            this.bntOpent.Location = new System.Drawing.Point(15, 38);
            this.bntOpent.Name = "bntOpent";
            this.bntOpent.Size = new System.Drawing.Size(120, 23);
            this.bntOpent.TabIndex = 1;
            this.bntOpent.Text = "打开(&O)";
            this.bntOpent.UseVisualStyleBackColor = true;
            this.bntOpent.Click += new System.EventHandler(this.bntOpent_Click);
            // 
            // textPaht
            // 
            this.textPaht.Enabled = false;
            this.textPaht.Location = new System.Drawing.Point(157, 15);
            this.textPaht.Multiline = true;
            this.textPaht.Name = "textPaht";
            this.textPaht.Size = new System.Drawing.Size(266, 77);
            this.textPaht.TabIndex = 2;
            // 
            // bntOk
            // 
            this.bntOk.Location = new System.Drawing.Point(15, 67);
            this.bntOk.Name = "bntOk";
            this.bntOk.Size = new System.Drawing.Size(120, 23);
            this.bntOk.TabIndex = 3;
            this.bntOk.Text = "确定(&D)";
            this.bntOk.UseVisualStyleBackColor = true;
            this.bntOk.Click += new System.EventHandler(this.bntOk_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmDataReole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 101);
            this.Controls.Add(this.bntOk);
            this.Controls.Add(this.textPaht);
            this.Controls.Add(this.bntOpent);
            this.Controls.Add(this.label1);
            this.Name = "frmDataReole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据还原";
            this.Load += new System.EventHandler(this.frmDataReole_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntOpent;
        private System.Windows.Forms.TextBox textPaht;
        private System.Windows.Forms.Button bntOk;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}