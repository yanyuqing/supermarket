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
            //������Ϣ
            frmJhGoodsInfo jhGOOD = new frmJhGoodsInfo();
            jhGOOD.Owner = this;
            jhGOOD.ShowDialog();
        }

        private void menuEmployee_Click(object sender, EventArgs e)
        {
            //Ա����Ϣ
            frmEmpInfo empinfo = new frmEmpInfo();
            empinfo.Owner = this;
            empinfo.ShowDialog();
        }

        private void menuCompany_Click(object sender, EventArgs e)
        {
            //��Ӧ����Ϣ
            frmCompanyInfo frmComp = new frmCompanyInfo();
            frmComp.Owner = this;
            frmComp.ShowDialog();
        }

        private void menuFind_Click(object sender, EventArgs e)
        {
            //��Ʒ��Ϣ���ѯ
            frmFindGood findgood = new frmFindGood();
            findgood.Owner = this;
            findgood.ShowDialog();
        }

        private void menuDepotAlarm_Click(object sender, EventArgs e)
        {
            //��澯��
            frmKcGoods kcGood = new frmKcGoods();
            kcGood.Owner = this;
            kcGood.ShowDialog();
        }

        private void menuDepotFind_Click(object sender, EventArgs e)
        {
            //����ѯ
            frmKcGoodFind kcfrmFind = new frmKcGoodFind();
            kcfrmFind.Owner = this;
            kcfrmFind.ShowDialog();
        }

        private void menuSellGoods_Click(object sender, EventArgs e)
        {
            //��Ʒ������Ϣ
            frmSellGoods frmSell = new frmSellGoods();
            frmSell.Owner = this;
            frmSell.ShowDialog();
        }

        private void menuSellFind_Click(object sender, EventArgs e)
        {
            //�˻���Ϣ
            frmThGoodsInfo frmTh = new frmThGoodsInfo();
            frmTh.Owner = this;
            frmTh.ShowDialog();
        }

       

        private void frmMain_Load(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            this.statusUser.Text = "ϵͳ����Ա��" +SendNameValue;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
   
            this.statusTime.Text = "��ǰʱ�䣺" + DateTime.Now.ToString();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void menuStockManage_Click(object sender, EventArgs e)
        {

        }

       
    }
}