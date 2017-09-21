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
    public partial class frmThGoodsInfo : Form
    {
        public frmThGoodsInfo()
        {
            InitializeComponent();
        }

        tb_ThGoodsInfo tbGoodinfo = new tb_ThGoodsInfo();
        tb_ThGoodsMenthod tbMendd = new tb_ThGoodsMenthod();
        public string goodid = null;
        public string Kcid = null;
        public int intCoun = 0;
        public void getClear()
        {

           txtThGoodsID.Text="";
             txtSellID.Text="";
             txtSellID.Text="";
            txtThGoodsName.Text="";
            txThGoodsNum.Text="";
            daThGoodsTime.Value = DateTime.Now; 
            txtThGoodsPrice.Text="";
            txtThHasPay.Text="";
             txtThNeedPay.Text="";
            txtThGoodsResult.Text="";
            txtDataTime.Text = "";
            txtPrice.Text = "";
            txtnum.Text = "";
            txtEmpID.Text = "";
        
        }


        public int retuCount()
        {
            int intResult = 0;
            if (intCoun == 2 || intCoun == 1)
            {
                if (txtThGoodsID.Text == "")
                {
                    MessageBox.Show("�˻���Ų���Ϊ�գ�");
                    return intResult;
                }
                if (txtSellID.Text == "")
                {
                    MessageBox.Show("���۱�Ų���Ϊ�գ�");
                    return intResult;
                }
                if (txThGoodsNum.Text == "")
                {
                    MessageBox.Show("�˻���������Ϊ�գ�");
                    return intResult;
                }
                if (txtThGoodsPrice.Text == "")
                {
                    MessageBox.Show("�˻����۲���Ϊ�գ�");
                    return intResult;
                }
                if (txtThHasPay.Text == "")
                {
                    MessageBox.Show("Ӧ������Ϊ�գ�");
                    return intResult;
                }
                if (txtThNeedPay.Text == "")
                {

                    MessageBox.Show("ʵ������Ϊ�գ�");
                    return intResult;
                }
                tbGoodinfo.strThGoodsID = txtThGoodsID.Text;
                tbGoodinfo.strKcID = Kcid;
                tbGoodinfo.strGoodsID = goodid;
                tbGoodinfo.strSellID = txtSellID.Text;
                tbGoodinfo.intEmpId = txtEmpID.Text;
                tbGoodinfo.strThGoodsName = txtThGoodsName.Text;
                tbGoodinfo.intThGoodsNum = Convert.ToInt32(txThGoodsNum.Text);
                tbGoodinfo.daThGoodsTime = daThGoodsTime.Value;
                tbGoodinfo.deThGoodsPrice = txtThGoodsPrice.Text;
                tbGoodinfo.deThHasPay = txtThHasPay.Text;
                tbGoodinfo.deThNeedPay = txtThNeedPay.Text;
                tbGoodinfo.deThGoodsResult = txtThGoodsResult.Text;
            }
            if (intCoun == 3)
            {
                if (txtThGoodsID.Text == "")
                {
                    MessageBox.Show("�˻���Ų���Ϊ�գ�,��ѡ��Ҫɾ����¼");
                    return intResult;
                }
            }
            return intResult=1;
         
        
        }

        private void frmThGoodsInfo_Load(object sender, EventArgs e)
        {
            tbMendd.tb_ThGoodsFind(dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmSellGoodInfo frmSell = new frmSellGoodInfo();
            frmSell.Owner = this;
            frmSell.ShowDialog();

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (intCoun == 2 || intCoun == 3)
                {
                    FillControls();
                    fillGet();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString());
            }
        }
        public void FillControls()
        {
            try
            {
                SqlDataReader sqldr = tbMendd.tb_JhGoodsInfoFind(this.dataGridView1[0, this.dataGridView1.CurrentCell.RowIndex].Value.ToString());
    
                sqldr.Read();
                if (sqldr.HasRows)
                {
                   
                    txtThGoodsID.Text = sqldr[0].ToString();
                    txThGoodsNum.Text= sqldr[6].ToString();
                    txtThGoodsPrice.Text=sqldr[8].ToString();
                    txtThHasPay.Text=sqldr[10].ToString();
                    txtThNeedPay.Text=sqldr[9].ToString();
                    txtThGoodsResult.Text=sqldr[11].ToString();
                    txtEmpID.Text=sqldr[4].ToString();
                    daThGoodsTime.Value = Convert.ToDateTime(sqldr[7].ToString());  
                }
                sqldr.Close();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());

            }
        
        }
        public void fillGet()
        {
            try {
                tb_SellGoodsMenthod tbsell = new tb_SellGoodsMenthod();
                SqlDataReader dr = tbsell.dtb_SellGoodsFind(this.dataGridView1[1, this.dataGridView1.CurrentCell.RowIndex].Value.ToString());
                dr.Read();
                if (dr.HasRows)
                {

                    txtSellID.Text = dr[0].ToString();
                   txtThGoodsName.Text = dr[4].ToString();
                   goodid = dr[2].ToString();
                    Kcid = dr[1].ToString();

                    txtDataTime.Text = dr[6].ToString();
                   txtPrice.Text = dr[7].ToString();
                    txtnum.Text = Convert.ToInt32(dr[5].ToString()).ToString();
           

                }
                dr.Close();

            
            
            
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString());
            }
        
        }
        private void ControlStatus()
        {
            this.toolSave.Enabled = !this.toolSave.Enabled;
            this.toolAdd.Enabled = !this.toolAdd.Enabled;
            this.toolCancel.Enabled = !this.toolCancel.Enabled;
            this.toolAmend.Enabled = !this.toolAmend.Enabled;
            this.toolDelete.Enabled = !toolDelete.Enabled;

        }
        //����
        private void toolSave_Click(object sender, EventArgs e)
        {
            if (retuCount() == 1)
            {
                if (intCoun == 1)
                {
                    if (tbMendd.tb_ThGoodsAdd(tbGoodinfo) == 1)
                    {
                        MessageBox.Show("��ӳɹ�");
                        ControlStatus();
                        getClear();
                        tbMendd.tb_ThGoodsFind(dataGridView1);
                        intCoun = 0;//i��ӱ��

                    }
                    else
                    {

                        MessageBox.Show("���ʧ��");
                        ControlStatus();
                        getClear();
                        tbMendd.tb_ThGoodsFind(dataGridView1);
                        intCoun = 0;//i��ӱ��

                    }
                 
                }
                if (intCoun == 2)
                {
                    if (tbMendd.tb_ThGoodsUpdate(tbGoodinfo) == 1)
                    {
                        MessageBox.Show("�޸ĳɹ�");
                        ControlStatus();
                        getClear();
                        tbMendd.tb_ThGoodsFind(dataGridView1);
                        intCoun = 0;//i��ӱ��

                    }
                    else
                    {

                        MessageBox.Show("�޸�ʧ��");
                        ControlStatus();
                        getClear();
                        tbMendd.tb_ThGoodsFind(dataGridView1);
                        intCoun = 0;//i��ӱ��
                    }
                }
                if (intCoun == 3)
                {
                    if (tbMendd.tb_ThGoodsDelete(txtThGoodsID.Text) == 1)
                    {
                        MessageBox.Show("ɾ���ɹ�");
                        ControlStatus();
                        getClear();
                        tbMendd.tb_ThGoodsFind(dataGridView1);
                        intCoun = 0;//i��ӱ��

                    }
                    else
                    {

                        MessageBox.Show("ɾ��ʧ��");
                        ControlStatus();
                        getClear();
                        tbMendd.tb_ThGoodsFind(dataGridView1);
                        intCoun = 0;//i��ӱ��
                    }
                }
            
            
            }
        }
        //ȡ��
        private void toolCancel_Click(object sender, EventArgs e)
        {
            ControlStatus();
            getClear();
        }
        //���
        private void toolAdd_Click(object sender, EventArgs e)
        {
            ControlStatus();
            getClear();
            txtThGoodsID.Text = tbMendd.tb_ThGoodsID();
            intCoun = 1;//i��ӱ��

        }
        //�޸�
        private void toolAmend_Click(object sender, EventArgs e)
        {

            ControlStatus();
            getClear();
            intCoun = 2;//i�޸ı��
        }
        //�˳�
        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txThGoodsNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("��������");
                e.Handled = true;
            }
        }

        private void txtThGoodsPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar)&&e.KeyChar!='.')
            {
                MessageBox.Show("��������");
                e.Handled = true;
            }
        }

        private void txtThNeedPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                MessageBox.Show("��������");
                e.Handled = true;
            }
        }

        private void txtThHasPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("��������");
                e.Handled = true;
            }
        }

        private void toolDelete_Click(object sender, EventArgs e)
        {
            ControlStatus();
            intCoun = 3;//i�޸ı��
        }
    }
}