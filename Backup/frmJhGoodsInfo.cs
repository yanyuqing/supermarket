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
    public partial class frmJhGoodsInfo : Form
    {
        public frmJhGoodsInfo()
        {
            InitializeComponent();
        }
        public frmJhGoodsInfo(int intCdo)
        {
            InitializeComponent();
        }

        tb_JhGoodsInfo jhGood=new tb_JhGoodsInfo();
        tb_JhGoodsInfoMenthod jhMenthod=new tb_JhGoodsInfoMenthod();
        public static int intFalg = 0;
        private void ControlStatus()
        {
            this.toolSave.Enabled = !this.toolSave.Enabled;
            this.toolAdd.Enabled = !this.toolAdd.Enabled;
            this.toolCancel.Enabled = !this.toolCancel.Enabled;
            this.toolAmend.Enabled = !this.toolAmend.Enabled;
            this.tollDelete.Enabled = !this.tollDelete.Enabled;
        }
        public void ClearContorl()
        {
            txtGoodsNum.Text = "";
            txtGoodsRemark.Text = "";
            txtGoodsSellPrice.Text = "";
            txtJhCompName.Text = "";
            txtGoodsNoPrice.Text = "";
            txtGoodsNeedPrice.Text = "";
            txtGoodsName.Text = "";
            txtGoodsJhPrice.Text = "";
            txtGoodsID.Text = "";
            txtEmpId.Text = "";
            cmbDepotName.Text = "";
        }
        public int getIntCount()
        {
            int intReslut = 0;
            if (intFalg == 1)
            {
                if (txtGoodsID.Text == "")
                {
                    MessageBox.Show("��Ʒ��Ų���Ϊ�գ�");
                    return intReslut;
                }
                if (txtGoodsName.Text == "")
                {
                    MessageBox.Show("��Ʒ���Ʋ���Ϊ�գ�");
                    return intReslut;
                }
                if (txtJhCompName.Text == "")
                {
                    MessageBox.Show("��Ӧ�����Ʋ���Ϊ�գ�");
                    return intReslut;
                }
                if (txtEmpId.Text == "")
                {
                    MessageBox.Show("��������������Ϊ�գ�");
                    return intReslut;
                }
                if (txtGoodsNum.Text == "")
                {
                    MessageBox.Show("��������Ϊ�գ�");
                    return intReslut;
                }
                if (txtGoodsName.Text == "")
                {
                    MessageBox.Show("�������۲���Ϊ�գ�");
                    return intReslut;
                }
            }
            if (intFalg == 2)
            {
                if (txtGoodsID.Text == "")
                {
                    MessageBox.Show("��Ʒ��Ų���Ϊ�գ�,ѡ��Ҫ�޸ļ�¼","��ʾ");
                    return intReslut;
                }
                
            }
            if (intFalg == 3)
            {
                if (txtGoodsID.Text == "")
                {
                    MessageBox.Show("��Ʒ��Ų���Ϊ�գ�,ѡ��Ҫɾ����¼", "��ʾ");
                    return intReslut;
                }
            }
            jhGood.strGoodsID = txtGoodsID.Text;
            jhGood.strEmpId = txtEmpId.Text;
            jhGood.strJhCompName = txtGoodsName.Text;
            jhGood.strDepotName = cmbDepotName.Text;
            jhGood.strGoodsNum = Convert.ToInt32(txtGoodsNum.Text);
            jhGood.strGoodsName = txtGoodsName.Text;
            jhGood.strGoodsUnit = cmbGoodsUnit.Text;
            jhGood.deGoodsJhPrice = txtGoodsJhPrice.Text;
            jhGood.deGoodsNeedPrice = txtGoodsNeedPrice.Text;
            jhGood.deGoodsNoPrice = txtGoodsNoPrice.Text;
            jhGood.deGoodsSellPrice = txtGoodsSellPrice.Text;
            jhGood.strGoodsRemark = txtGoodsRemark.Text;
            jhGood.DaGoodTime = dateTimePicker1.Value;
            if (intFalg != 3)
            {
                jhGood.Falg = 0;
            }
            else
            {
                jhGood.Falg = 1;
            }
            intReslut = 1;
            return intReslut;
        }
        private void frmJhGoodsInfo_Load(object sender, EventArgs e)
        {
            jhMenthod.tb_JhGoodsInfoFind("", 5, dataGridView1);
        }
        private void FillControls()
        {
            try
            {
                
                SqlDataReader sqldr = jhMenthod.tb_JhGoodsInfoFind(this.dataGridView1[0, this.dataGridView1.CurrentCell.RowIndex].Value.ToString(),1);

                sqldr.Read();
                if (sqldr.HasRows)
                {

                     txtEmpId.Text=sqldr[1].ToString();
                      txtGoodsName.Text=sqldr[4].ToString();
                      cmbDepotName.Text = sqldr[3].ToString();
                    

                   txtGoodsNum.Text=sqldr[5].ToString();
                    cmbGoodsUnit.Text=sqldr[6].ToString();
                    txtGoodsJhPrice.Text=sqldr[7].ToString();
                    txtGoodsNeedPrice.Text=sqldr[9].ToString();
                  ��txtGoodsNoPrice.Text=sqldr[10].ToString();
                    txtGoodsSellPrice.Text=sqldr[8].ToString();
                    txtGoodsRemark.Text=sqldr[11].ToString();
                    txtJhCompName.Text = sqldr[2].ToString();
                 
                    txtGoodsID.Text = sqldr[0].ToString();
                   ��txtGoodsID.Enabled = false;
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolAdd_Click(object sender, EventArgs e)
        {
            ControlStatus();
            ClearContorl();
            intFalg = 1;//��ӱ��
            txtGoodsID.Text = jhMenthod.JhGoodsID();
             txtGoodsID.Enabled = false;
        }

        private void toolAmend_Click(object sender, EventArgs e)
        {
            ControlStatus();
            ClearContorl();
            intFalg = 2;//��ӱ��
        }

        private void toolrefulsh_Click(object sender, EventArgs e)
        {
            ControlStatus();
            ClearContorl();
    

        }

        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolCancel_Click(object sender, EventArgs e)
        {
            ControlStatus();
            ClearContorl();


        }

        private void toolSave_Click(object sender, EventArgs e)
        {
            if (getIntCount() == 1)
            {
                if (intFalg == 1)
                {
                    if (jhMenthod.tb_JhGoodsInfoMenthodAdd(jhGood)==2)
                    {
                        MessageBox.Show("��ӳɹ�","��ʾ");
                        intFalg = 0;
                        jhMenthod.tb_JhGoodsInfoFind("",5,dataGridView1);
                        ControlStatus();
                        ClearContorl();
                    }
                    else
                    {
                        MessageBox.Show("���ʧ��", "��ʾ");
                        intFalg = 0;
                        jhMenthod.tb_JhGoodsInfoFind("", 5, dataGridView1);
                        ControlStatus();
                        ClearContorl();
                    }

                }
                if (intFalg == 2)
                {
                    if (jhMenthod.tb_JhGoodsInfoMenthodUpdate(jhGood)==1)
                    {
                        MessageBox.Show("�޸ĳɹ�", "��ʾ");
                        intFalg = 0;
                        jhMenthod.tb_JhGoodsInfoFind("", 5, dataGridView1);
                        ControlStatus();
                        ClearContorl();
                    }
                    else
                    {
                        MessageBox.Show("�޸�ʧ��", "��ʾ");
                        intFalg = 0;
                        jhMenthod.tb_JhGoodsInfoFind("", 5, dataGridView1);
                        ControlStatus();
                        ClearContorl();
                    }

                }
                if (intFalg == 3)
                {
                    if (jhMenthod.tb_JhGoodsInfoMenthodDelete(jhGood)==1)
                    {
                        MessageBox.Show("ɾ���ɹ�", "��ʾ");
                        intFalg = 0;
                        jhMenthod.tb_JhGoodsInfoFind("", 5, dataGridView1);
                        ControlStatus();
                        ClearContorl();
                    }
                    else
                    {
                        MessageBox.Show("ɾ��ʧ��", "��ʾ");
                        intFalg = 0;
                        jhMenthod.tb_JhGoodsInfoFind("", 5, dataGridView1);
                        ControlStatus();
                        ClearContorl();
                    }

                }
            
            
            
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (intFalg == 2 || intFalg == 3)
            {
                FillControls();
            }
        }



        private void txtGoodsJhPrice_TextChanged(object sender, EventArgs e)
        {
           if (txtGoodsNum.Text != "")
            {

                txtGoodsNeedPrice.Text = Convert.ToString(Convert.ToInt32(txtGoodsJhPrice.Text)*Convert.ToInt32(txtGoodsNum.Text));
            }

        }


        private void txtGoodsSellPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar)&&e.KeyChar!='.') 
            {
                MessageBox.Show("����������");
                e.Handled = true;
            }
        }

        private void txtGoodsNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar)) 
            {
                MessageBox.Show("����������");
                e.Handled = true;
            }
         
        }

        private void txtGoodsJhPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar) && e.KeyChar != '.') 
            {
                MessageBox.Show("����������");
                e.Handled = true;
            }
    

        }

        private void txtGoodsNoPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar) && e.KeyChar != '.') 
            {
                MessageBox.Show("����������");
                e.Handled = true;
            }
        }
        //��Ӧ����Ϣ
        private void button1_Click(object sender, EventArgs e)
        {
            frmGonYingShang frmgong = new frmGonYingShang();
            frmgong.Owner = this;
            frmgong.ShowDialog();
        }


        private void tollDelete_Click(object sender, EventArgs e)
        {
            ControlStatus();
            ClearContorl();
            intFalg = 3;//��ӱ��
        }

   

 
    }
}