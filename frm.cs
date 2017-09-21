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
    }
}