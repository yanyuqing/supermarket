using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CHEXC
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public frmMain(string strName)
        {
            InitializeComponent();
            SendNameValue = strName;
        }
        public string SendNameValue;
        private void menuGoodsIn_Click(object sender, EventArgs e)
        {
            //进贷信息
            frmJhGoodsInfo jhGOOD = new frmJhGoodsInfo();
            jhGOOD.Owner = this;
            jhGOOD.ShowDialog();
        }

        private void menuEmployee_Click(object sender, EventArgs e)
        {
            //员工信息
            frmEmpInfo empinfo = new frmEmpInfo();
            empinfo.Owner = this;
            empinfo.ShowDialog();
        }

        private void menuCompany_Click(object sender, EventArgs e)
        {
            //供应商信息
            frmCompanyInfo frmComp = new frmCompanyInfo();
            frmComp.Owner = this;
            frmComp.ShowDialog();
        }

        private void menuFind_Click(object sender, EventArgs e)
        {
            //商品信息查查询
            frmFindGood findgood = new frmFindGood();
            findgood.Owner = this;
            findgood.ShowDialog();
        }

        private void menuDepotAlarm_Click(object sender, EventArgs e)
        {
            //库存警报
            frmKcGoods kcGood = new frmKcGoods();
            kcGood.Owner = this;
            kcGood.ShowDialog();
        }

        private void menuDepotFind_Click(object sender, EventArgs e)
        {
            //库存查询
            frmKcGoodFind kcfrmFind = new frmKcGoodFind();
            kcfrmFind.Owner = this;
            kcfrmFind.ShowDialog();
        }

        private void menuSellGoods_Click(object sender, EventArgs e)
        {
            //商品销售信息
            frmSellGoods frmSell = new frmSellGoods();
            frmSell.Owner = this;
            frmSell.ShowDialog();
        }

        private void menuSellFind_Click(object sender, EventArgs e)
        {
            //退货信息
            frmThGoodsInfo frmTh = new frmThGoodsInfo();
            frmTh.Owner = this;
            frmTh.ShowDialog();
        }

        private void 数据备份HToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //数据备份
            frmDataBack frmBack = new frmDataBack();
            frmBack.Owner = this;
            frmBack.ShowDialog();
        }

        private void 数据还原IToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //数据还源
            frmDataReole frmReole = new frmDataReole();
            frmReole.Owner = this;
            frmReole.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            this.statusUser.Text = "系统操作员：" +SendNameValue;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
   
            this.statusTime.Text = "当前时间：" + DateTime.Now.ToString();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void 原始数据下载ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://win.51aspx.com/CV/SuperMarketIncome");

        }
    }
}