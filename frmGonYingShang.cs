using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CHEXC.GoodMenhod;
namespace CHEXC
{
    public partial class frmGonYingShang : Form
    {
        public frmGonYingShang()
        {
            InitializeComponent();
        }
        tb_JhGoodsInfoMenthod jhMenthod = new tb_JhGoodsInfoMenthod();
        private void frmGonYingShang_Load(object sender, EventArgs e)
        {
            jhMenthod.filltProd(this.treeView1,imageList1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCompanyInfo ComPan = new frmCompanyInfo(1);
            ComPan.Owner = this;
            ComPan.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Text != "")
            {
                frmJhGoodsInfo jhGood = (frmJhGoodsInfo)this.Owner;
                jhGood.txtJhCompName.Text = treeView1.SelectedNode.Text;
                this.Close();

            }
            else
            {
                MessageBox.Show("选择供应商信息");
            }
        }
    }
}