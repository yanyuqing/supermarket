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
    public partial class frmSellGoods : Form
    {
        public frmSellGoods()
        {
            InitializeComponent();
        }

        tb_SellGoods sellGoods = new tb_SellGoods();
        tb_SellGoodsMenthod sellMenthod = new tb_SellGoodsMenthod();
        public int intCount = 0;
        public string kcId = "";
        public string GoodId = null;
        private void frmSellGoods_Load(object sender, EventArgs e)
        {
            sellMenthod.tb_SellGoodsFind(dataGridView1);
        }
        private void ControlStatus()
        {
            this.toolSave.Enabled = !this.toolSave.Enabled;
            this.toolAdd.Enabled = !this.toolAdd.Enabled;
            this.toolCancel.Enabled = !this.toolCancel.Enabled;
            this.toolAmend.Enabled = !this.toolAmend.Enabled;
            this.toolDelete.Enabled=!this.toolDelete.Enabled;
        }

        public void Clear()
        {
            txtSellID.Text = "";
            txtEmpID.Text = "";
            txtGoodsName.Text = "";
            txtdeSellPrice.Text = "";
            txSellNeedPay.Text = "";
            txtSellGoodsNum.Text = "";
            txtdeSellHasPay.Text = "";
            txtSellRemark.Text = "";
        }
        public int fillGetInfo()
        {
            int intResult = 0;
            if(intCount==1 ||intCount==2)
            {
                if(txtSellID.Text=="")
                {
                    MessageBox.Show("��Ʒ���۱�Ų���Ϊ��");
                    return intResult;
                }
                if (txtGoodsName.Text == "")
                {
                    MessageBox.Show("��Ʒ���Ʋ���Ϊ��");
                    return intResult;
                }
                if (txtSellGoodsNum.Text == "")
                {
                    MessageBox.Show("��Ʒ��������Ϊ��");
                    return intResult;
                }
                if (txtdeSellPrice.Text == "")
                {
                    MessageBox.Show("��Ʒ�۸���Ϊ��");
                    return intResult;
                }
                if (txtdeSellHasPay.Text == "")
                {
                    MessageBox.Show("ʵ������Ϊ��");
                    return intResult;
                }
                sellGoods.strSellID = txtSellID.Text;
                sellGoods.strKcID = kcId.ToString();
                sellGoods.strGoodsID = GoodId;
                sellGoods.strEmpId = txtEmpID.Text;
                sellGoods.strGoodsName = txtGoodsName.Text;
                sellGoods.strSellGoodsNum = Convert.ToInt32(txtSellGoodsNum.Text);
                sellGoods.daSellGoodsTime = DaSellGoodsTime.Value;
                sellGoods.deSellPrice = txtdeSellPrice.Text;
                sellGoods.deSellNeedPay = txSellNeedPay.Text;
                sellGoods.deSellHasPay = txtdeSellHasPay.Text;
                sellGoods.strSellRemark = txtSellRemark.Text;
            }
            if(intCount!=3)
            {
                sellGoods.intSellFalg = 0;
            }
            else
            {
                if (txtSellID.Text == "")
                {
                    MessageBox.Show("��Ʒ���۱�Ų���Ϊ�գ�,��ѡ��Ҫɾ������Ʒ��Ϣ","��Ϣ��ʾ");
                    return intResult;
                }
                sellGoods.strSellID = txtSellID.Text;
                sellGoods.intSellFalg = 1;
            }
            intResult = 1;
            return intResult;
        }
        //����
        private void toolSave_Click(object sender, EventArgs e)
        {
            if (fillGetInfo() == 1)
            {
                if (intCount == 1)
                {
                    if (sellMenthod.tb_SellGoodsAdd(sellGoods) == 1)
                    {
                        MessageBox.Show("��ӳɹ�");
                        Clear();
                        ControlStatus();
                        intCount = 0;//��ӱ��
                        sellMenthod.tb_SellGoodsFind(dataGridView1);
                    }
                    else
                    {

                        MessageBox.Show("���ʧ��");
                        Clear();
                        ControlStatus();
                        intCount = 0;//��ӱ��
                    }
                
                }
                if (intCount == 2)
                {
                    if (sellMenthod.tb_SellGoodsUpdate(sellGoods) == 1)
                    {
                        MessageBox.Show("�޸ĳɹ�");
                        Clear();
                        ControlStatus();
                        intCount = 0;//��ӱ��
                        sellMenthod.tb_SellGoodsFind(dataGridView1);
                    }
                    else
                    {

                        MessageBox.Show("�޸�ʧ��");
                        Clear();
                        ControlStatus();
                        intCount = 0;//��ӱ��
                    }
                }
                if (intCount == 3)
                {
                    if (sellMenthod.tb_SellGoodsDelete(sellGoods) == 1)
                    {
                        MessageBox.Show("ɾ���ɹ�");
                        Clear();
                        ControlStatus();
                        intCount = 0;//��ӱ��
                        sellMenthod.tb_SellGoodsFind(dataGridView1);

                    }
                    else
                    {
                        MessageBox.Show("ɾ��ʧ��");
                        Clear();
                        ControlStatus();
                        intCount = 0;//��ӱ��
                    }
                }
            }//
        }
        //ȡ��
        private void toolCancel_Click(object sender, EventArgs e)
        {
            Clear();
            ControlStatus();
            intCount = 0;//��ӱ��
        }
        //���
        private void toolAdd_Click(object sender, EventArgs e)
        {
            Clear();
            ControlStatus();
            intCount = 1;//��ӱ��
            txtSellID.Text = sellMenthod.getSellID();
            txtSellID.Enabled = false;
        }
        //�޸�
        private void toolAmend_Click(object sender, EventArgs e)
        {
            Clear();
            ControlStatus();
            intCount = 2;//�޸ı��
        }
       //�ر�
        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //ѡ����Ʒ����
        private void button2_Click(object sender, EventArgs e)
        {
            frmGoodID frmid = new frmGoodID();
            frmid.Owner = this;
            frmid.ShowDialog();
        }

        private void txtdeSellPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar)) 
            {
                MessageBox.Show("��������");
                e.Handled = true;
            }
        }

        private void txtSellGoodsNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar)) 
            {
                MessageBox.Show("��������");
                e.Handled = true;
            }
        }

        private void txtdeSellHasPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar)&&e.KeyChar!='.') 
            {
                MessageBox.Show("��������");
                e.Handled = true;
            }
        }

        private void txtSellGoodsNum_TextChanged(object sender, EventArgs e)
        {
            if (txtdeSellPrice.Text != "")
            {
                txSellNeedPay.Text =Convert.ToString(Convert.ToInt32(txtdeSellPrice.Text) * Convert.ToInt32(txtSellGoodsNum.Text));
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (intCount == 2 || intCount == 3)
            {
                FillControls();
            }
        }
        private void FillControls()
        {
            try
            {
                SqlDataReader sqldr = sellMenthod.dtb_SellGoodsFind(this.dataGridView1[0, this.dataGridView1.CurrentCell.RowIndex].Value.ToString());
                sqldr.Read();
                if (sqldr.HasRows)
                {

                    txtSellID.Text = sqldr[0].ToString();
                    txtSellID.Enabled = false;
                    txtEmpID.Text = sqldr[3].ToString();
                    txtGoodsName.Text = sqldr[4].ToString();
                    txtSellGoodsNum.Text = sqldr[5].ToString();
                    DaSellGoodsTime.Value = Convert.ToDateTime(sqldr[6].ToString());
                    txtSellRemark.Text = sqldr[10].ToString();
                    txtdeSellPrice.Text = sqldr[7].ToString();
                    txSellNeedPay.Text = sqldr[8].ToString();
                    txtdeSellHasPay.Text = sqldr[9].ToString();
                }
                sqldr.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void txtdeSellHasPay_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolDelete_Click(object sender, EventArgs e)
        {
            ControlStatus();
            intCount = 3;//�޸ı��
        }

    }
}