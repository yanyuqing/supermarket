using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

using System.Windows.Forms;
using CHEXC.ClassInfo;
using CHEXC.GoodMenhod;
using System.Data.SqlClient;
namespace CHEXC
{
    public partial class frmKcGoods : Form
    {
        public frmKcGoods()
        {
            InitializeComponent();
        }

        tb_KcGoods kcGood = new tb_KcGoods();
        tb_KcGoodsMenthod tb_GoodMenthd = new tb_KcGoodsMenthod();
        private void frmKcGoods_Load(object sender, EventArgs e)
        {
            tb_GoodMenthd.tb_ThGoodsFind(dataGridView1,4,kcGood);
        }
        private void FillControls()
        {
            try
            {
                SqlDataReader sqldr = tb_GoodMenthd.tb_ThGoodsFind(this.dataGridView1[0, this.dataGridView1.CurrentCell.RowIndex].Value.ToString());
                  
                sqldr.Read();
                if (sqldr.HasRows)
                {
                    txtid.Text = sqldr[1].ToString();
                    txtGoodsName.Text = sqldr[2].ToString();
                    txtGoodsJhPrice.Text = sqldr[9].ToString();
                    txtGoodsSellPrice.Text=sqldr[10].ToString();
                    txtGoodsNum.Text = sqldr[5].ToString();
                }
                sqldr.Close();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());

            }
        }
        public void ClearFill()
        {
            txtid.Text ="";
            txtGoodsName.Text = "";
            txtGoodsJhPrice.Text = "";
            txtGoodsSellPrice.Text = "";
            txtGoodsNum.Text = "";
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("����������");
                e.Handled = true;
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FillControls();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("��ѡ����Ʒ��Ϣ");
                return;
            }
            if (txtnum.Text == "")
            {
                MessageBox.Show("��������Ʒ��������");
                return;
            }
            int intResult = tb_GoodMenthd.tb_KcGoodsUpdate(txtid.Text, Convert.ToInt32(txtnum.Text));
            if (intResult == 1)
            {
                MessageBox.Show("��ӳɹ���");
                tb_GoodMenthd.tb_ThGoodsFind(dataGridView1, 4, kcGood);
                ClearFill();
            }
            else
            {
                MessageBox.Show("���ʧ�ܣ�");
                ClearFill();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}