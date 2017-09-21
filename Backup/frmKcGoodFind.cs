using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CHEXC.GoodMenhod;
using CHEXC.ClassInfo;

namespace CHEXC
{
    public partial class frmKcGoodFind : Form
    {
        public frmKcGoodFind()
        {
            InitializeComponent();
        }

        tb_KcGoodsMenthod tb_GoodMenthd = new tb_KcGoodsMenthod();
        tb_KcGoods kcgood = new tb_KcGoods();
  
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("请选择查询条件！");
                return;
            }
            if (txtkey.Text == "")
            {
                MessageBox.Show("请输入查询信息");
                return;
            }
            switch (comboBox1.Text)
            {
                case "商品编号"://"商品编号":
                    kcgood.strGoodsID = txtkey.Text;
                    tb_GoodMenthd.tb_ThGoodsFind(dataGridView1,1,kcgood);
                    break;
                case "商品名称"://商品名称"
                    kcgood.strKcGoodsName = txtkey.Text;
                    tb_GoodMenthd.tb_ThGoodsFind(dataGridView1, 2, kcgood);
                    break;
            }
        }

        private void frmKcGoodFind_Load(object sender, EventArgs e)
        {

        }
    }
}